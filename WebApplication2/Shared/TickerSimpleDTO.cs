using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


    public class TickerSimpleDTO
    {
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string Market { get; set; }
        public string Shortcode { get; set; }
        public string? IconUrl { get; set; }
    }

