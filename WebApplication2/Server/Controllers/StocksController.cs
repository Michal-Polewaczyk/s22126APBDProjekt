using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace s22126_projekt_apbd.Server.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {

        private readonly IStockApiService _stockService;

        public StocksController(IStockApiService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet("{tickerName}/{date}")]
        public async Task<IActionResult> GetDailyOpenCloseData(string tickerName, DateTime date)
        {
            DailyOpenCloseDTO response = await _stockService.GetDailyOpenClose(tickerName, date);
            if (response != null)
            {
                return Ok(response);
            }
            return NotFound();
        }

        [HttpGet("{tickerName}")]
        public async Task<IActionResult> GetTickerDetails(string tickerName)
        {
            TickerSimpleDTO response = await _stockService.GetTickerDetails(tickerName);
            if (response != null)
            {
                return Ok(response);
            }
            return NotFound();
        }

        [HttpGet("{tickerName}/Prizes/{from}")]
        public async Task<IActionResult> GetTickerPrizes(string tickerName, DateTime from)
        {
            TickerPricesDTO response = await _stockService.GetTickerPrices(tickerName,from);
            if (response != null)
            {
                return Ok(response);
            }
            return NotFound();
        }

        [HttpGet("{tickerName}/News/{numberOfNews}")]
        public async Task<IActionResult> GetLatestNewsAboutTicker(string tickerName, int numberOfNews)
        {
            IEnumerable<TickerNewsDTO> response = await _stockService.GetLatestNewsAboutTicker(tickerName, numberOfNews);
            if (response != null)
            {
                return Ok(response);
            }
            return NotFound();
        }

        [HttpGet("/Tickers")]
        public async Task<IActionResult> GetAllTickersMatchingToString([FromQuery(Name = "match")] string matchParameter)
        {
            string match = matchParameter != null? matchParameter : "";
            IEnumerable<TickerDetailsDTO> response = await _stockService.GetAllTickersMatchingToString(match);
            if (response != null)
            {
                return Ok(response);
            }
            return NotFound();
        }

    }
}
