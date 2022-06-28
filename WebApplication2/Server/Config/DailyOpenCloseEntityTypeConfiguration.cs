using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Server.Models;

namespace WebApplication2.Server.Config
{
    public class DailyOpenCloseEntityTypeConfiguration : IEntityTypeConfiguration<DailyOpenClose>
    {
        public void Configure(EntityTypeBuilder<DailyOpenClose> builder)
        {
            builder.HasKey(d => d.IdDailyOpenClose);
            builder.Property(d => d.IdDailyOpenClose).ValueGeneratedOnAdd();
            builder.Property(d => d.IdTicker).IsRequired();
            builder.Property(d => d.Status).IsRequired();
            builder.Property(d => d.From).IsRequired();
            builder.Property(d => d.Symbol).IsRequired();
            builder.Property(d => d.Open).IsRequired();
            builder.Property(d => d.High).IsRequired();
            builder.Property(d => d.Low).IsRequired();
            builder.Property(d => d.Close).IsRequired();
            builder.Property(d => d.Volume).IsRequired();
            builder.Property(d => d.AfterHours).IsRequired();
            builder.Property(d => d.PreMarket).IsRequired();

            builder.HasOne(d => d.IdTickerNavigation)
                .WithMany(t => t.DailyOpenCloses)
                .HasForeignKey(d => d.IdTicker)
                .OnDelete(DeleteBehavior.NoAction);
               
        }
    }
}
