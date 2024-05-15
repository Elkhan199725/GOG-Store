using GOG.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Configurations;

public class NewsArticleConfiguration : IEntityTypeConfiguration<NewsArticle>
{
    public void Configure(EntityTypeBuilder<NewsArticle> builder)
    {
        // Primary Key
        builder.HasKey(na => na.Id);

        // Properties
        builder.Property(na => na.Title)
               .IsRequired()
               .HasMaxLength(200);

        builder.Property(na => na.Content)
               .IsRequired();

        builder.Property(na => na.PublishedDate)
               .IsRequired();

        // Relationships
        builder.HasMany(na => na.MediaItems)
               .WithOne()
               .HasForeignKey(m => m.MediaOwnerId)
               .OnDelete(DeleteBehavior.Cascade);

        // Corrected Relationships to use join tables
        builder.HasMany(na => na.NewsArticleCategories)
               .WithOne(nac => nac.NewsArticle)
               .HasForeignKey(nac => nac.NewsArticleId);

        builder.HasMany(na => na.NewsArticleTags)
               .WithOne(nat => nat.NewsArticle)
               .HasForeignKey(nat => nat.NewsArticleId);

        // Indexes
        builder.HasIndex(na => na.PublishedDate);
    }
}