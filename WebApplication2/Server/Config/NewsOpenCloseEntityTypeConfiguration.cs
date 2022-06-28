using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Server.Models;

namespace WebApplication2.Server.Config
{
    public class NewsOpenCloseEntityTypeConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.HasKey(n => n.IdNews);
            builder.Property(n => n.IdNews).ValueGeneratedOnAdd();
            builder.Property(n => n.Title).IsRequired().HasMaxLength(50);
            builder.Property(n => n.DateOfPublishing).IsRequired();
            builder.Property(n => n.IdTicker).IsRequired();

            builder.HasOne(n => n.IdTickerNavigation)
                .WithMany(t => t.NewsNavigation)
                .HasForeignKey(n => n.IdTicker)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
