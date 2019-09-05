using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorConference.Models
{
    public class Attendee
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int? Age { get; set; }
    }
}
