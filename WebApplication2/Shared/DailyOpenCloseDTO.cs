using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


    public class DailyOpenCloseDTO
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("from")]
        public DateTime From { get; set; }
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
        [JsonPropertyName("open")]
        public double Open { get; set; }
        [JsonPropertyName("high")]
        public double High { get; set; }
        [JsonPropertyName("low")]
        public double Low { get; set; }
        [JsonPropertyName("close")]
        public double Close { get; set; }
        [JsonPropertyName("volume")]
        public double Volume { get; set; }
        [JsonPropertyName("afterHours")]
        public double AfterHours { get; set; }
        [JsonPropertyName("preMarket")]
        public double PreMarket { get; set; }

    
}
