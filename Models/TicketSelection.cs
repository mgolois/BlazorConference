using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorConference.Models
{
    public class TicketSelection
    {
        public Ticket Ticket { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be a positive number")]
        public int Quantity { get; set; }
        public double? Price => Ticket?.Price * Quantity;
        public List<Attendee> Attendees { get; set; }
    }
}
