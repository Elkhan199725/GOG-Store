using GOG.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Configurations;

public class PlatformConfiguration : IEntityTypeConfiguration<Platform>
{
    public void Configure(EntityTypeBuilder<Platform> builder)
    {
        // Primary Key
        builder.HasKey(p => p.Id);

        // Properties
        builder.Property(p => p.Name)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(p => p.Description)
               .HasMaxLength(1000);

        // Relationships
        builder.HasMany(p => p.GamePlatforms)
               .WithOne(gp => gp.Platform)
               .HasForeignKey(gp => gp.PlatformId);

        builder.HasMany(p => p.MediaItems)
               .WithOne()
               .HasForeignKey(m => m.MediaOwnerId)
               .OnDelete(DeleteBehavior.Cascade);

        // Indexes
        builder.HasIndex(p => p.Name).IsUnique();
    }
}