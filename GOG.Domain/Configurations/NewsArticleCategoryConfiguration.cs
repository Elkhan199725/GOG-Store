using GOG.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Configurations;

public class NewsArticleCategoryConfiguration : IEntityTypeConfiguration<NewsArticleCategory>
{
    public void Configure(EntityTypeBuilder<NewsArticleCategory> builder)
    {
        // Composite Primary Key
        builder.HasKey(nac => new { nac.NewsArticleId, nac.NewsCategoryId });

        // Relationships
        builder.HasOne(nac => nac.NewsArticle)
               .WithMany(na => na.NewsArticleCategories)
               .HasForeignKey(nac => nac.NewsArticleId);

        builder.HasOne(nac => nac.NewsCategory)
               .WithMany(nc => nc.NewsArticleCategories)
               .HasForeignKey(nac => nac.NewsCategoryId);
    }
}