using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Server.Models;

namespace WebApplication2.Server.Config
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AggregateResultDTO, AggregateResult>();
            CreateMap<TickerDetailsDTO, Ticker>().ForMember(t => t.IconUrl, opt => opt.MapFrom(td => td.Branding.IconUrl));
            CreateMap<TickerNewsDTO, News>();
            CreateMap<TickerPricesDTO, Price>();
            CreateMap<DailyOpenCloseDTO, DailyOpenClose>();

            CreateMap<AggregateResult,AggregateResultDTO>();
            CreateMap<Ticker,TickerDetailsDTO>();
            CreateMap<News,TickerNewsDTO>();
            CreateMap<Price,TickerPricesDTO>();
            CreateMap<DailyOpenClose,DailyOpenCloseDTO>();

            CreateMap<TickerSimpleDTO, Ticker>();
            CreateMap<Ticker, TickerSimpleDTO>();

            CreateMap<TickerDetailsDTO, TickerSimpleDTO>().ForMember(t => t.IconUrl, opt => opt.MapFrom(td => td.Branding.IconUrl));
        }
    }
}
