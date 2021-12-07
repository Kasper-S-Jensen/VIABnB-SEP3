﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SEP3T2GraphQL.Models;

namespace SEP3T2GraphQL.Repositories.Impl
{
    public class HostRepositoryImpl : IHostRepository
    {
        
        private string uri = "http://localhost:8080";
        private readonly HttpClient client;

        public HostRepositoryImpl()
        {
            client = new HttpClient();
        }
        
        public async Task<Host> RegisterHostAsync(Host host)
        {

            string newHost = JsonSerializer.Serialize(host, new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            
            Console.WriteLine(newHost);
            StringContent content = new StringContent(newHost, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await client.PostAsync(uri + "/host", content);
            Console.WriteLine("before if in rep");
            if (!responseMessage.IsSuccessStatusCode)
            {
                Console.WriteLine("inside if in rep");
                Console.WriteLine(await responseMessage.Content.ReadAsStringAsync());
                throw new Exception(await responseMessage.Content.ReadAsStringAsync());
            }

            Host h = JsonSerializer.Deserialize<Host>(await responseMessage.Content.ReadAsStringAsync(), new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            Console.WriteLine(h.ToString()); 
            return h;
        }


        public async Task<Host> GetHostByEmail(string email)
        {
            Console.WriteLine("before get host by email");
            var response = await client.GetAsync(uri + $"/host?email={email}");
            Console.WriteLine("after get host by email");

            Console.WriteLine(await response.Content.ReadAsStringAsync());
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"{this} caught exception: {await response.Content.ReadAsStringAsync()} with status code {response.StatusCode}");
                throw new Exception(await response.Content.ReadAsStringAsync());
            }
            
            var result = await response.Content.ReadAsStringAsync();
            if (string.IsNullOrEmpty(result))
            {
                return null;
            }
            var host = JsonSerializer.Deserialize<Host>(result, new JsonSerializerOptions(
                new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                }));
            return host;
        }

        public async Task<Host> GetHostById(int id)
        {
            HttpResponseMessage responseMessage = await client.GetAsync(uri + $"/host/{id}");

            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"$Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            string result = await responseMessage.Content.ReadAsStringAsync();
            Host host = JsonSerializer.Deserialize<Host>(result, new JsonSerializerOptions(
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }));
            return host;
        }

        public async Task<Host> ValidateHostAsync(Host host)
        {
            var returnedHost = await GetHostByEmail(host.Email);
            if (returnedHost != null && returnedHost.Password == host.Password)
            {
                return host;
            }
            else return null;
        }

        public Task<Host> UpdateHost(Host host)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Host>> GetAllNotApprovedHosts()
        {
            var response = await client.GetAsync(uri + $"/hosts/notApproved");
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"{this} caught exception: {await response.Content.ReadAsStringAsync()} with status code {response.StatusCode}");
                throw new Exception(await response.Content.ReadAsStringAsync());
            }

            var result = await response.Content.ReadAsStringAsync();
            var hostListToReturn = JsonSerializer.Deserialize<List<Host>>(result, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return hostListToReturn;
        }

        public async Task<Host> UpdateHostStatus(Host host)
        {
            var hostAsJson = JsonSerializer.Serialize(host, new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            HttpContent content = new StringContent(hostAsJson, Encoding.UTF8, "application/json");
            var response = await client.PatchAsync($"{uri}/hosts/{host.Id}/approval", content);
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"{this} caught exception: {await response.Content.ReadAsStringAsync()} with status code {response.StatusCode}");
                throw new Exception(await response.Content.ReadAsStringAsync());
            }

            var updatedHost = JsonSerializer.Deserialize<Host>(await response.Content.ReadAsStringAsync(),
                new JsonSerializerOptions()
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });

            return updatedHost;
        }
    }
}