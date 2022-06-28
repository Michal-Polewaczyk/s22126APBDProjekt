using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


    public class AggregateResultDTO
    {
        [JsonPropertyName("c")]
        public double ClosePriceForTheSymbol { get; set; }
        [JsonPropertyName("h")]
        public double HighestPriceForTheSymbol { get; set; }
        [JsonPropertyName("l")]
        public double LowestPriceForTheSymbol { get; set; }
        [JsonPropertyName("n")]
        public int NumberOfTransactions { get; set; }
        [JsonPropertyName("o")]
        public double OpenPriceForTheSymbol { get; set; }
        [JsonPropertyName("t")]
        public long UnixMilisecondTimestamp { get; set; }
        [JsonPropertyName("v")]
        public double TradingVolumeOfTheSymbol { get; set; }
        [JsonPropertyName("vw")]
        public double VolumeWeightedAveragePrice { get; set; }
    
}
