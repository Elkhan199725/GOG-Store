using GOG.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Configurations;

public class NewsTagConfiguration : IEntityTypeConfiguration<NewsTag>
{
    public void Configure(EntityTypeBuilder<NewsTag> builder)
    {
        // Primary Key
        builder.HasKey(nt => nt.Id);

        // Properties
        builder.Property(nt => nt.Name)
               .IsRequired()
               .HasMaxLength(100);

        // Relationships
        builder.HasMany(nt => nt.NewsArticleTags)
               .WithOne(nat => nat.NewsTag)
               .HasForeignKey(nat => nat.NewsTagId);

        // Indexes
        builder.HasIndex(nt => nt.Name).IsUnique();
    }
}