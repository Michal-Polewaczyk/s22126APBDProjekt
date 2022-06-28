using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Server.Models
{
    public class Price
    {
        public int IdPrice { get; set; }
        public int IdTicker { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public virtual Ticker IdTickerNavigation { get; set; }
        public virtual ICollection<AggregateResult> AggregateResultsNavigation { get; set; }
    }
}
