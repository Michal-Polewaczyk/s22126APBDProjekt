using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Server.Models;

namespace WebApplication2.Server.Config
{
    public class AggregateResultEntityTypeConfiguration : IEntityTypeConfiguration<AggregateResult>
    {
        public void Configure(EntityTypeBuilder<AggregateResult> builder)
        {
            builder.HasKey(a => a.IdAggregateResult);
            builder.Property(a => a.IdAggregateResult).ValueGeneratedOnAdd();
            builder.Property(a => a.IdPrice).IsRequired();
            builder.Property(a => a.ClosePriceForTheSymbol).IsRequired();
            builder.Property(a => a.HighestPriceForTheSymbol).IsRequired();
            builder.Property(a => a.LowestPriceForTheSymbol).IsRequired();
            builder.Property(a => a.NumberOfTransactions).IsRequired();
            builder.Property(a => a.OpenPriceForTheSymbol).IsRequired();
            builder.Property(a => a.UnixMilisecondTimestamp).IsRequired();
            builder.Property(a => a.TradingVolumeOfTheSymbol).IsRequired();
            builder.Property(a => a.VolumeWeightedAveragePrice).IsRequired();
            builder.Property(a => a.VolumeWeightedAveragePrice).IsRequired();

            builder.HasOne(a => a.IdPriceNavigation)
                .WithMany(p => p.AggregateResultsNavigation)
                .HasForeignKey(a => a.IdPrice)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
