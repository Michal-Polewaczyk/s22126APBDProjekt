using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Server.Models
{
    public class AggregateResult
    {
        public int IdAggregateResult { get; set; }
        public int IdPrice { get; set; }
        public double ClosePriceForTheSymbol { get; set; }
         
        public double HighestPriceForTheSymbol { get; set; }
         
        public double LowestPriceForTheSymbol { get; set; }
         
        public int NumberOfTransactions { get; set; }
       
        public double OpenPriceForTheSymbol { get; set; }
       
        public long UnixMilisecondTimestamp { get; set; }
        
        public double TradingVolumeOfTheSymbol { get; set; }
        
        public double VolumeWeightedAveragePrice { get; set; }
        public virtual Price IdPriceNavigation { get; set; }
    }
}
