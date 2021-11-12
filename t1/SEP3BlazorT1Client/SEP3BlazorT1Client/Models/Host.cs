﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SEP3BlazorT1Client.Models
{
    public class Host
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public IList<HostReview> HostReviews { get; set; } = new List<HostReview>();
        public string ProfileImageUrl { get; set; }
        public bool IsApprovedHost { get; set; } = false; 
    }
}