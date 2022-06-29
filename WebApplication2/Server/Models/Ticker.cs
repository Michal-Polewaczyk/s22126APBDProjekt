using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Server.Models
{
    public class Ticker
    {
        public int IdTicker { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string Market { get; set; }
        public string ShortCode { get; set; }
        public string? IconUrl { get; set; }
        public virtual ICollection<News> NewsNavigation { get; set; }
        public virtual ICollection<Price> PricesNavigation { get; set; }
        public virtual ICollection<ApplicationUserTicker> WatchersNavigation { get; set; }
        public virtual ICollection<DailyOpenClose> DailyOpenCloses { get; set; }
    }
}
