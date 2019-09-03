using BlazorConference.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorConference.ViewModels
{
    public class ContactViewModel:ComponentBase
    {
        protected ContactRequest Request { get; set; } = new ContactRequest();

        protected void OnFormSubmitted()
        {

        }
    }
}
