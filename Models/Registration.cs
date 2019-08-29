using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorConference.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public int? FromAge { get; set; }
        public int? ToAge { get; set; }
        public bool AgeRequired => FromAge.HasValue && ToAge.HasValue;

    }

    public class TicketSelection
    {
        public Ticket Ticket { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be a positive number")]
        public int Quantity { get; set; }
        public double? Price => Ticket?.Price * Quantity;
        public List<Attendee> Attendees { get; set; }
    }

    public class Registration
    {
        public List<TicketSelection> TicketSelections { get; set; } = new List<TicketSelection>();
        public double? TotalPrice => TicketSelections.Sum(c => c.Price);
    }

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
