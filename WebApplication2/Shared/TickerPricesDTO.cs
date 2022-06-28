using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


    public class TickerPricesDTO
    {
        [JsonPropertyName("ticker")]
        public string Ticker { get; set; }
        [JsonPropertyName("queryCount")]
        public int QueryCount { get; set; }
        [JsonPropertyName("resultsCount")]
        public int ResultsCount { get; set; }
        [JsonPropertyName("results")]
        public IEnumerable<AggregateResultDTO> Results { get; set; }
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
        [JsonPropertyName("count")]
        public int count { get; set; }
        [JsonPropertyName("from")]
        public DateTime From { get; set; }


}
