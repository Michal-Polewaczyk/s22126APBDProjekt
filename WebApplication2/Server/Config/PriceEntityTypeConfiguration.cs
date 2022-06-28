using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Server.Models;

namespace WebApplication2.Server.Config
{
    public class PriceEntityTypeConfiguration : IEntityTypeConfiguration<Price>
    {
        public void Configure(EntityTypeBuilder<Price> builder)
        {
            builder.HasKey(p => p.IdPrice);
            builder.Property(p => p.IdTicker).IsRequired();
            builder.Property(p => p.From).IsRequired();
            builder.Property(p => p.To).IsRequired();

            builder.HasOne(p => p.IdTickerNavigation)
                .WithMany(t => t.PricesNavigation)
                .HasForeignKey(p => p.IdTicker)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(p => p.AggregateResultsNavigation)
                .WithOne(a => a.IdPriceNavigation)
                .HasForeignKey(p => p.IdPrice)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
