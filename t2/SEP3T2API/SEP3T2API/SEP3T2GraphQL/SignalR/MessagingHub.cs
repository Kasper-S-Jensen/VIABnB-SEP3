﻿using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SEP3T2GraphQL.Models;
using SEP3T2GraphQL.Services;

namespace SEP3T2GraphQL.SignalR
{
    public class MessagingHub : Hub
    {
        private readonly IMessagingService _messagingService;
        private readonly IUserService _userService;

        /// Maps the connected users' userId to a connection string to be used for direct messaging.  
        private static ConcurrentDictionary<int, string> _clients = new();

        public MessagingHub(IMessagingService messagingService, IUserService userService)
        {
            _messagingService = messagingService;
            _userService = userService;
        }

        public override async Task OnConnectedAsync()
        {
            var userEmail = Context.GetHttpContext().Request.Query["email"];
            var existingUser = await _userService.GetUserByEmailAsync(userEmail);
            if (existingUser != null)
            {
                // Each time a client joins, they get a new connection string
                // If user has already been connected before without disconnecting, then we update the string. 
                if (_clients.ContainsKey(existingUser.Id))
                {
                    Console.WriteLine($"{this} updating user {existingUser.Id} with new connection string {Context.ConnectionId}");
                    _clients[existingUser.Id] = Context.ConnectionId;
                }

                Join(existingUser.Id);
                Console.WriteLine(
                    $"User with email {existingUser.Email} joined with connection {Context.ConnectionId}.");
            }
        }

        public async override Task OnDisconnectedAsync(Exception? exception)
        {
            // This method is a bit slow, since we might have to loop through every key in the map.
            // Might have to switch the key / value such that connectionId is the key instead. 
            foreach (var key in _clients.Keys)
            {
                if (_clients[key] == Context.ConnectionId)
                {
                    Disconnect(key);
                    break;
                }
            }
        }

        public async Task GetMessages()
        {
            // This method is a bit slow, since we might have to loop through every key in the map.
            // Might have to switch the key / value such that connectionId is the key instead. 
            foreach (var key in _clients.Keys)
            {
                if (_clients[key] == Context.ConnectionId)
                {
                    Console.WriteLine($"{this} received request for {nameof(GetMessages)} from {Context.ConnectionId}");
                    var messages = await _messagingService.GetMessagesByUserIdAsync(key);
                    var messagesAsJson = JsonSerializer.Serialize(messages,
                        new JsonSerializerOptions() {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                    await Clients.Client(_clients[key])
                        .SendCoreAsync("ReceiveUserMessages", new object[] {messagesAsJson});
                    break;
                }
            }
        }

        public async Task SendMessage(string messageAsJson)
        {
            var message = JsonSerializer.Deserialize<Message>(messageAsJson);
            try
            {
                var sentMessage = await _messagingService.SendMessageAsync(message);
                if (_clients.ContainsKey(sentMessage.Receiver.Id))
                {
                    var sentMessageAsJson = JsonSerializer.Serialize(sentMessage,
                        new JsonSerializerOptions() {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                    await Clients.Client(_clients[sentMessage.Receiver.Id])
                        .SendCoreAsync("ReceiveMessage", new object[] {sentMessageAsJson});
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private async void Join(int userId)
        {
            _clients.TryAdd(userId, Context.ConnectionId);
            await Clients.Client(_clients[userId])
                .SendCoreAsync("ReceiveUserMessages",
                    new object[] {await _messagingService.GetMessagesByUserIdAsync(userId)});
        }

        public void Disconnect(int userId)
        {
            if (_clients.ContainsKey(userId))
            {
                Console.WriteLine($"User with id {userId} disconnected");
                var connectionString = _clients[userId];
                _clients.TryRemove(userId, out _);
            }
        }
    }
}