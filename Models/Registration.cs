using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorConference.Models
{
    public class Registration
    {
        public BillingInformation BillingInfo { get; set; } = new BillingInformation();
        public List<TicketSelection> TicketSelections { get; set; } = new List<TicketSelection>();
        public double? TotalPrice => TicketSelections.Sum(c => c.Price);
    }
}