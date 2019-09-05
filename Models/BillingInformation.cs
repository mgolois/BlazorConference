using BlazorConference.Utils.Validations;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorConference.Models
{
    public class BillingInformation
    {
        [Required]
        [CreditCard]
        public string CardNumber { get; set; }

        [Required]
        public string ExpirationMonth { get; set; }

        [Required]
        [Range(2019, int.MaxValue)]
        [ValidExpiration("ExpirationMonth")]
        public int ExperirationYear { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(4)]
        public string SecurityCode { get; set; }

        [Required]
        public string CardType { get; set; }

        [Required]
        public string Address { get; set; }
        public string State { get; set; }
        [Required]
        public string City { get; set; }
        public string Zipcode { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Comment { get; set; }
        public string FullAddress => $"{Address}, {City}, {State}, {Zipcode}, {Country}";
    }
}
