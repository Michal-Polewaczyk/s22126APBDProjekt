using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Server.Models
{
    public class News
    {
        public int IdNews { get; set; }
        public int IdTicker { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DateOfPublishing { get; set; }
        public string UrlToArticle { get; set; }

        public virtual Ticker IdTickerNavigation {get;set;} 
    }
}
