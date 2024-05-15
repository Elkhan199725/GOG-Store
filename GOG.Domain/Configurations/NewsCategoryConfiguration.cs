using GOG.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Configurations;

public class NewsCategoryConfiguration : IEntityTypeConfiguration<NewsCategory>
{
    public void Configure(EntityTypeBuilder<NewsCategory> builder)
    {
        // Primary Key
        builder.HasKey(nc => nc.Id);

        // Properties
        builder.Property(nc => nc.Name)
               .IsRequired()
               .HasMaxLength(100);

        // Relationships
        builder.HasMany(nc => nc.NewsArticleCategories)
               .WithOne(nac => nac.NewsCategory)
               .HasForeignKey(nac => nac.NewsCategoryId);

        // Indexes
        builder.HasIndex(nc => nc.Name).IsUnique();
    }
}