using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorConference.Models
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public DateTime Date { get; set; }
        public int Order { get; set; } = 0;
        public bool Active { get; set; }
    }
}
