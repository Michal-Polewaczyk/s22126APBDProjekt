using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Server.Models
{
    public class DailyOpenClose
    {
        public int IdDailyOpenClose { get; set; }
        public int IdTicker { get; set; }
        public string Status { get; set; }
        public DateTime From { get; set; }
        public string Symbol { get; set; }
        public double Open { get; set; }
        public double High { get; set; } 
        public double Low { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }
        public double AfterHours { get; set; }
        public double PreMarket { get; set; }
        public Ticker IdTickerNavigation { get; set; }
    }
}
