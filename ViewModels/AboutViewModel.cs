using BlazorConference.Models;
using BlazorConference.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorConference.ViewModels
{
    public class AboutViewModel : ComponentBase
    {
        [Inject]
        protected NewsService NewsService { get; set; }
        protected List<NewsItem> newsItems { get; set; }

        protected override async Task OnInitializedAsync()
        {
            newsItems = await NewsService.GetActiveNews();
        }
    }
}
