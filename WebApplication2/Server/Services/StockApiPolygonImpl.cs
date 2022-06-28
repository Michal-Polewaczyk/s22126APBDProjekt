using AutoMapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication2.Server.Models;

public class StockApiPolygonImpl : IStockApiService
    {

        private readonly HttpClient _httpClient;
        private readonly IDbService _dbService;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;

    private readonly int _aggregateLimit;
        private readonly int _limitOfNews;

        private readonly string DAILY_OPEN_CLOSE_URL_TEMPLATE = "https://api.polygon.io/v1/open-close/{0}/{1}?apiKey={2}";
        private readonly string AGGREGATE_BARS_URL_TEMPLATE = "https://api.polygon.io/v2/aggs/ticker/{0}/range/1/day/{1}/{2}?adjusted=false&sort=asc&limit={3}&apiKey={4}";
        private readonly string TICKER_DETAILS_URL_TEMPLATE = "https://api.polygon.io/v3/reference/tickers/{0}?apiKey={1}";
        private readonly string TICKER_LATEST_NEWS_URL_TEMPLATE = "https://api.polygon.io/v2/reference/news?ticker={0}&limit={1}&apiKey={2}";
        private readonly string _polygonApiKey;
        private readonly CommonDateNotationConverter _converter;

        public StockApiPolygonImpl(HttpClient httpClient, IDbService dbService, IConfiguration configuration, IMapper mapper)
        {
            _httpClient = httpClient;
            _dbService = dbService;
         _config = configuration;
        _mapper = mapper;
        _polygonApiKey = _config.GetValue<string>("PolygonApiKey");
        _aggregateLimit = 20;
        _limitOfNews = 5;
        _converter = new CommonDateNotationConverter();
        }

    public async Task<IEnumerable<TickerDetailsDTO>> GetAllTickersMatchingToString(string matcher)
    {
        string tickersUrl = $"https://api.polygon.io/v3/reference/tickers?active=true&sort=ticker&ticker.gte={matcher}&order=asc&limit=10&apiKey={_polygonApiKey}";
        HttpResponseMessage response = await _httpClient.GetAsync(tickersUrl);
        IEnumerable<TickerDetailsDTO> matchingTickers = new List<TickerDetailsDTO>();
        try
        {
            string responseToString = await response.Content.ReadAsStringAsync();
            matchingTickers = JsonSerializer.Deserialize<TickerDetailsResultsDTO>(responseToString).TickerDetailsDTO;
            if (matchingTickers == null)
            {
                matchingTickers = await _dbService.GetAllTickersMatchingToString(matcher);
            }
        } catch(Exception e)
        {
            matchingTickers = await _dbService.GetAllTickersMatchingToString(matcher);
        }
       
        return matchingTickers.Distinct().Take(5);
    }

    public async Task<DailyOpenCloseDTO> GetDailyOpenClose(string tickerName, DateTime date)
        {
                HttpResponseMessage response = await _httpClient.GetAsync(String.Format(
                    DAILY_OPEN_CLOSE_URL_TEMPLATE, tickerName, _converter.FormatDateTimeToApiFriendlyFormat(date), _polygonApiKey
                    ));

                string responseToString = await response.Content.ReadAsStringAsync();
                DailyOpenCloseDTO dailyOpenCloseDto = JsonSerializer.Deserialize<DailyOpenCloseDTO>(responseToString);
                
        if(!response.StatusCode.Equals(HttpStatusCode.OK))
        {
            DailyOpenClose dailyOpenClose = await _dbService.GetDailyOpenClose(tickerName, date);
            dailyOpenCloseDto = _mapper.Map<DailyOpenClose,DailyOpenCloseDTO>(dailyOpenClose);
        }
        await _dbService.AddDailyOpenClose(_mapper.Map<DailyOpenCloseDTO, DailyOpenClose>(dailyOpenCloseDto),tickerName);
        return dailyOpenCloseDto;
        }

    public async Task<IEnumerable<TickerNewsDTO>> GetLatestNewsAboutTicker(string tickerName, int numberOfLatestNews)
    {
        HttpResponseMessage response = await _httpClient.GetAsync(String.Format(
            TICKER_LATEST_NEWS_URL_TEMPLATE,
            tickerName,numberOfLatestNews,
            _polygonApiKey
            ));

        string responseToString = await response.Content.ReadAsStringAsync();
        IEnumerable<TickerNewsDTO> tickerNewsDtos = JsonSerializer.Deserialize<TickerNewsResultsDTO>(responseToString).TickerNews;

        if (!response.StatusCode.Equals(HttpStatusCode.OK))
        {
            IEnumerable<News> news = await _dbService.GetLatestNewsAboutTicker(tickerName, numberOfLatestNews);
            tickerNewsDtos = news.Select(n => _mapper.Map<News, TickerNewsDTO>(n)); 
        }
        tickerNewsDtos.Select(t => _dbService.AddLatestNewsAboutTicker(_mapper.Map<TickerNewsDTO, News>(t),tickerName));
        return tickerNewsDtos;
    }

    public async Task<TickerSimpleDTO> GetTickerDetails(string tickerName)
        {
        HttpResponseMessage response = await _httpClient.GetAsync(String.Format(
            TICKER_DETAILS_URL_TEMPLATE, tickerName, _polygonApiKey
            ));

        string responseToString = await response.Content.ReadAsStringAsync();
        TickerDetailsDTO tickerDetailsDTO = JsonSerializer.Deserialize<TickerResultDTO>(responseToString).TickerDetailsDTO;  

        TickerSimpleDTO tickerSimpleDTO = _mapper.Map<TickerDetailsDTO, TickerSimpleDTO>(tickerDetailsDTO);
        if (!response.StatusCode.Equals(HttpStatusCode.OK))
        {
            Ticker ticker = await _dbService.GetTickerDetails(tickerName);
            if (ticker == null) return null;
            return _mapper.Map<Ticker, TickerSimpleDTO>(ticker);
        }
        if(tickerSimpleDTO.IconUrl != null)
        {
            tickerSimpleDTO.IconUrl = tickerSimpleDTO.IconUrl + $"?apiKey={_polygonApiKey}";
        }
        

        await _dbService.AddTicker(_mapper.Map<TickerSimpleDTO, Ticker>(tickerSimpleDTO));
        return tickerSimpleDTO;
    }

        public async Task<TickerPricesDTO> GetTickerPrices(string tickerName, DateTime from)
        {
        HttpResponseMessage response = await _httpClient.GetAsync(String.Format(
            AGGREGATE_BARS_URL_TEMPLATE,
            tickerName,
            _converter.FormatDateTimeToApiFriendlyFormat(from),
            _converter.FormatDateTimeToApiFriendlyFormat(DateTime.Now),
            _aggregateLimit,
            _polygonApiKey
            ));
        string responseToString = await response.Content.ReadAsStringAsync();
        TickerPricesDTO tickerPriceDTO = JsonSerializer.Deserialize<TickerPricesDTO>(responseToString);
        tickerPriceDTO.From = from;
        if (!response.StatusCode.Equals(HttpStatusCode.OK))
        {
            Price price = await _dbService.GetTickerPrices(tickerName,from);
            tickerPriceDTO = _mapper.Map<Price,TickerPricesDTO>(price);
        }
        await _dbService.AddTickerPrices(_mapper.Map<TickerPricesDTO,Price>(tickerPriceDTO),tickerName);
        return tickerPriceDTO;
    }
}
