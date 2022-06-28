using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Server.Data;
using WebApplication2.Server.Models;

public class SqlServerDbImpl : IDbService
{

    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    public SqlServerDbImpl(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task AddDailyOpenClose(DailyOpenClose dailyOpenClose,string tickername)
    {
        dailyOpenClose.IdTicker = _context.Tickers.Where(t => t.ShortCode.Equals(tickername)).First().IdTicker;
        await _context.DailyOpenCloses.AddAsync(dailyOpenClose);
        await _context.SaveChangesAsync();
    }

    public async Task AddLatestNewsAboutTicker(News news, string tickername)
    {
        news.IdTicker = _context.Tickers.Where(t => t.ShortCode.Equals(tickername)).First().IdTicker;
        await _context.News.AddAsync(news);
        await _context.SaveChangesAsync();
    }

    public async Task AddTicker(Ticker ticker)
    {
        await _context.Tickers.AddAsync(ticker);
        await _context.SaveChangesAsync();
    }

    public async Task AddTickerPrices(Price tickerPrizes, string tickername)
    {
        tickerPrizes.IdTicker = _context.Tickers.Where(t => t.ShortCode.Equals(tickername)).First().IdTicker;
        await _context.Prices.AddAsync(tickerPrizes);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<TickerDetailsDTO>> GetAllTickersMatchingToString(string matcher)
    {
        IEnumerable<TickerDetailsDTO> matchingRecords = await _context.Tickers.Where(t => t.Name.Contains(matcher) || t.ShortCode.Contains(matcher)).Select(t => _mapper.Map<Ticker,TickerDetailsDTO>(t)).ToListAsync();
        return matchingRecords;
    }

    public async Task<DailyOpenClose> GetDailyOpenClose(string tickerName, DateTime date)
    {
        DailyOpenClose dailyOpenClose = await _context.DailyOpenCloses.Include(d => d.IdTickerNavigation)
            .Where(d => d.IdTickerNavigation.Name.Equals(tickerName))
            .Where(d => d.From.Year == date.Year && d.From.Month == date.Month && d.From.Day == date.Day)
            .FirstOrDefaultAsync();
        return dailyOpenClose;
    }

    public async Task<IEnumerable<News>> GetLatestNewsAboutTicker(string tickerName, int numberOfLatestNews)
    {
        ICollection<News> news = await _context.News.Include(d => d.IdTickerNavigation)
            .Where(d => d.IdTickerNavigation.Name.Equals(tickerName))
            .ToListAsync();
        return news;
    }

    public async Task<Ticker> GetTickerDetails(string tickerName)
    {
        Ticker ticker = await _context.Tickers.Where(t => t.ShortCode.Equals(tickerName)).FirstOrDefaultAsync();
        return ticker;
    }

    public async Task<Price> GetTickerPrices(string tickerName, DateTime from)
    {

        Price price = await _context.Prices.Include(d => d.IdTickerNavigation)
            .Where(d => d.IdTickerNavigation.Name.Equals(tickerName))
            .Where(d => d.From.Year == from.Year && d.From.Month == from.Month && d.From.Day == from.Day)
            .Include(d => d.AggregateResultsNavigation)
            .FirstOrDefaultAsync();
        return price;
    }
}

