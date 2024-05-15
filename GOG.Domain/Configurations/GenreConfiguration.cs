using GOG.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Configurations;

public class GenreConfiguration : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        // Primary Key
        builder.HasKey(g => g.Id);

        // Properties
        builder.Property(g => g.Name)
               .IsRequired()
               .HasMaxLength(100); // Setting a reasonable max length for genre names

        builder.Property(g => g.Description)
               .HasMaxLength(1000); // Optional, max length for descriptions

        // Relationships
        builder.HasMany(g => g.GameGenres)
               .WithOne(gg => gg.Genre)
               .HasForeignKey(gg => gg.GenreId);

        // Indexes
        builder.HasIndex(g => g.Name).IsUnique(); // Ensure genre names are unique
    }
}
