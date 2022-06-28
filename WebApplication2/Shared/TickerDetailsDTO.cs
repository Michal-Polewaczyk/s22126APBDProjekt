using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

    public class TickerDetailsDTO
    {
        [JsonPropertyName("locale")]
        public string CountryCode { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("market")]
        public string Market { get; set; }
        
    [JsonPropertyName("ticker")]
    public string ShortCode { get; set; }

    [JsonPropertyName("branding")]
    public Branding? Branding { get; set; }

    public override bool Equals(object obj)
    {
        return obj is TickerDetailsDTO dTO &&
               ShortCode == dTO.ShortCode;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, ShortCode);
    }
}
