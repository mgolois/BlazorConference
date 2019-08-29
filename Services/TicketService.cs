using BlazorConference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorConference.Services
{
    public class TicketService
    {
        public async Task<List<Ticket>> GetTicketsAsync()
        {
            return await Task.FromResult(new List<Ticket>()
            {
                new Ticket { Id = Guid.Parse("A78E5F2F-0092-4420-81EF-B81101966F28"), Price=50, Type = "General Admission",},
                new Ticket { Id = Guid.Parse("A78E5F2F-0092-4420-81EF-B81101966F29"), Price=25, Type = "Youth Prophetic Admission", FromAge = 6, ToAge=12},
                new Ticket { Id = Guid.Parse("A78E5F2F-0092-4420-81EF-B81101966F30"), Price=15, Type = "Children Admission", FromAge = 2, ToAge=5}
            });
        }
    }
}
