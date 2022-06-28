using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Server.Models;

namespace WebApplication2.Server.Config
{
    public class TickerEntityTypeConfiguration : IEntityTypeConfiguration<Ticker>
    {
        public void Configure(EntityTypeBuilder<Ticker> builder)
        {
            builder.HasKey(t => t.IdTicker);
            builder.Property(t => t.IdTicker).ValueGeneratedOnAdd();//.UseIdentityColumn(1000, 1);
            builder.Property(t => t.Name).HasMaxLength(140).IsRequired();
            builder.Property(t => t.Market).HasMaxLength(140).IsRequired();
            builder.Property(t => t.ShortCode).HasMaxLength(4).IsRequired();
            builder.Property(t => t.IconUrl);

            builder.HasMany(t => t.PricesNavigation)
                .WithOne(p => p.IdTickerNavigation)
                .HasForeignKey(p => p.IdTicker)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(t => t.NewsNavigation)
                .WithOne(n => n.IdTickerNavigation)
                .HasForeignKey(n => n.IdTicker)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(t => t.DailyOpenCloses)
                .WithOne(d => d.IdTickerNavigation)
                .HasForeignKey(n => n.IdTicker)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(t => t.WatchersNavigation)
                .WithMany(w => w.WatchedTickers);
        }
    }
}
