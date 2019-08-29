using BlazorConference.Models;
using BlazorConference.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorConference.ViewModels
{
    public class RegisterModel : ComponentBase
    {
        protected Registration registration;

        [Inject]
        protected TicketService ticketService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            var tickets = await ticketService.GetTicketsAsync();
            registration = new Registration();
            tickets.ForEach(t => registration.TicketSelections.Add(new TicketSelection
            {
                Quantity = 0,
                Ticket = t,
                Attendees = new List<Attendee>()
            }));
        }
        protected void SubmitRegistration()
        {
            var model = registration.TicketSelections;
        }

        protected void InvalidRegistration()
        {
            var model = registration.TicketSelections;
        }
        protected void QuantityChanged(TicketSelection selection, int quantity)
        {
            quantity = quantity < 0 ? 0 : quantity;
            selection.Quantity = quantity;
            selection.Attendees = new List<Attendee>();
            selection.Attendees = Enumerable.Range(0, quantity).Select(c => new Attendee()).ToList();
        }

        protected void OnTicketUpdated(TicketSelection selection, Guid attendeeId, dynamic value, int order)
        {
            var attendee = selection.Attendees.FirstOrDefault(c => c.Id == attendeeId);
            switch (order)
            {
                case 0:
                    attendee.FirstName = value;
                    break;
                case 1:
                    attendee.LastName = value;
                    break;
                case 2:
                    attendee.Age = value;
                    break;
                default:
                    break;
            }

        }
    }
}
