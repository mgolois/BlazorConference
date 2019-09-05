using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace BlazorConference.Models
{
    public class ContactInformation
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Comment { get; set; }
    }
}
