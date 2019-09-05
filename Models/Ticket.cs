using System;

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
}
