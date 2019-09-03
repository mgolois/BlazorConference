using BlazorConference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorConference.Services
{
    public class NewsService
    {
        public async Task<List<NewsItem>> GetActiveNews()
        {
            var items = new List<NewsItem>
            {
                new NewsItem { Active = true, Date = DateTime.Parse("6/29/2019"), Description="Conference Update#2 Email", Id=1, Link="https://mailchi.mp/b687467a24ef/washington-prophetic-conference-2018-update-2", Order=1}
                , new NewsItem {Active=true, Date = DateTime.Parse("6/14/2019"), Description="Fasting and Prayer week (June 18 - 24, 2019)", Order=2, Id=2, Link=null}
                , new NewsItem {Active=true, Date = DateTime.Parse("6/10/2019"), Description="Conference Prayer topics", Id=3, Link="https://mailchi.mp/ece4d73cc6ba/washington-prophetic-conference-2018-prayer-topics", Order=3}
                , new NewsItem {Active=true, Date = DateTime.Parse("6/01/2019"), Description="Conference Update#1 Email", Id=4, Link="https://mailchi.mp/ece4d73cc6ba/washington-prophetic-conference-2018-prayer-topics", Order=4}
            };
            return await Task.FromResult(items);
        }
    }
}
