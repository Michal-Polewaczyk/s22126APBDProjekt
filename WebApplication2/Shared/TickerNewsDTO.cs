using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


    public class TickerNewsDTO
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("author")]
        public string Author { get; set; }
        [JsonPropertyName("published_utc")]
        public DateTime DateOfPublishing { get; set; }
        [JsonPropertyName("article_url")]
        public string UrlToArticle { get; set; }
    
}
