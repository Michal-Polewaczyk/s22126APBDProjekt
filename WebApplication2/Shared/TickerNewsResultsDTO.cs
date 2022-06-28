using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


    public class TickerNewsResultsDTO
    {
        [JsonPropertyName("results")]
        public IEnumerable<TickerNewsDTO> TickerNews { get; set; }
    }

