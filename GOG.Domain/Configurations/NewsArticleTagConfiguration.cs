using GOG.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Configurations;

public class NewsArticleTagConfiguration : IEntityTypeConfiguration<NewsArticleTag>
{
    public void Configure(EntityTypeBuilder<NewsArticleTag> builder)
    {
        // Composite Primary Key
        builder.HasKey(nat => new { nat.NewsArticleId, nat.NewsTagId });

        // Relationships
        builder.HasOne(nat => nat.NewsArticle)
               .WithMany(na => na.NewsArticleTags)
               .HasForeignKey(nat => nat.NewsArticleId);

        builder.HasOne(nat => nat.NewsTag)
               .WithMany(nt => nt.NewsArticleTags)
               .HasForeignKey(nat => nat.NewsTagId);
    }
}