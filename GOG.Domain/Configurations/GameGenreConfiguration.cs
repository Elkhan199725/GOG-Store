using GOG.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Configurations;

public class GameGenreConfiguration : IEntityTypeConfiguration<GameGenre>
{
    public void Configure(EntityTypeBuilder<GameGenre> builder)
    {
        // Composite Primary Key
        builder.HasKey(gg => new { gg.GameId, gg.GenreId });

        // Relationships
        builder.HasOne(gg => gg.Game)
               .WithMany(g => g.GameGenres)
               .HasForeignKey(gg => gg.GameId);

        builder.HasOne(gg => gg.Genre)
               .WithMany(g => g.GameGenres)
               .HasForeignKey(gg => gg.GenreId);
    }
}
