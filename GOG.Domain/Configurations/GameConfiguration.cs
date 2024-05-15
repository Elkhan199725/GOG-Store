using GOG.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Configurations;

public class GameConfiguration : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        // Primary Key
        builder.HasKey(g => g.Id);

        // Properties
        builder.Property(g => g.Title)
               .IsRequired()
               .HasMaxLength(200);

        builder.Property(g => g.Description)
               .IsRequired();

        builder.Property(g => g.ReleaseDate)
               .IsRequired();

        builder.Property(g => g.Price)
               .HasColumnType("decimal(18,2)");

        builder.Property(g => g.DiscountRate)
               .HasColumnType("decimal(5,2)");

        // Relationships
        builder.HasOne(g => g.Developer)
               .WithMany(d => d.Games)
               .HasForeignKey(g => g.DeveloperId);

        builder.HasMany(g => g.GameGenres)
               .WithOne(gg => gg.Game)
               .HasForeignKey(gg => gg.GameId);

        builder.HasMany(g => g.GamePlatforms)
               .WithOne(gp => gp.Game)
               .HasForeignKey(gp => gp.GameId);

        builder.HasMany(g => g.MediaItems)
               .WithOne()
               .HasForeignKey(m => m.MediaOwnerId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(g => g.Comments)
               .WithOne(c => c.Game)
               .HasForeignKey(c => c.GameId);

        // Indexes
        builder.HasIndex(g => g.Title).IsUnique();
    }
}