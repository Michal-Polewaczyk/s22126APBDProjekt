using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Server.Models;

public interface IDbService
    {
    public Task<DailyOpenClose> GetDailyOpenClose(string tickerName, DateTime date);
    public Task<Ticker> GetTickerDetails(string tickerName);
    public Task<Price> GetTickerPrices(string tickerName, DateTime from);
    public Task<IEnumerable<News>> GetLatestNewsAboutTicker(string tickerName, int numberOfLatestNews);
    public Task AddDailyOpenClose(DailyOpenClose dailyOpenClose, string tickername);
    public Task AddTicker(Ticker ticker);
    public Task AddLatestNewsAboutTicker(News news, string tickername);
    public Task AddTickerPrices(Price tickerPrizes, string tickername);
    public Task<IEnumerable<TickerDetailsDTO>> GetAllTickersMatchingToString(string matcher);
    public Task<bool> AddTickerToUserWatchlist(string UserEmail, string TickerName);
    public Task<IEnumerable<TickerSimpleDTO>> GetTickersFromUsersWatchlist(string UserEmail);
    public Task DeleteDeleteFromWatchlist(string UserEmail, string TickerName);

}

