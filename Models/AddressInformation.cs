using System.ComponentModel.DataAnnotations;

namespace BlazorConference.Models
{
    public class AddressInformation : ContactInformation
    {
        [Required]
        public string Address { get; set; }
        public string State { get; set; }
        [Required]
        public string City { get; set; }
        public string Zipcode { get; set; }
        [Required]
        public string Country { get; set; }

        public string FullAddress => $"{Address}, {City}, {State}, {Zipcode}, {Country}";

    }
}
