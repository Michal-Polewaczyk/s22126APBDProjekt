using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


    public interface IStockApiService
    {
        public Task<DailyOpenCloseDTO> GetDailyOpenClose(string tickerName, DateTime date);
        public Task<TickerSimpleDTO> GetTickerDetails(string tickerName);
        public Task<TickerPricesDTO> GetTickerPrices(string tickerName, DateTime from);
        public Task<IEnumerable<TickerNewsDTO>> GetLatestNewsAboutTicker(string tickerName, int numberOfLatestNews);
        public Task<IEnumerable<TickerDetailsDTO>> GetAllTickersMatchingToString(string matcher);
    
}
