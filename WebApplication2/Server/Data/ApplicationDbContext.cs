using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Server.Config;
using WebApplication2.Server.Models;

namespace WebApplication2.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }


        public virtual DbSet<Ticker> Tickers { get; set; }
        public virtual DbSet<AggregateResult> AggregateResults { get; set; }
        public virtual DbSet<DailyOpenClose> DailyOpenCloses { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<ApplicationUserTicker> ApplicationUserTickers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AggregateResultEntityTypeConfiguration());
            builder.ApplyConfiguration(new ApplicationUserEntityTypeConfiguration());
            builder.ApplyConfiguration(new DailyOpenCloseEntityTypeConfiguration());
            builder.ApplyConfiguration(new PriceEntityTypeConfiguration());
            builder.ApplyConfiguration(new TickerEntityTypeConfiguration());
            builder.ApplyConfiguration(new NewsOpenCloseEntityTypeConfiguration());
            builder.ApplyConfiguration(new ApplicationUserTickerEntityTypeConfiguration());
        }

    }
}
