using GOG.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Configurations;

public class GamePlatformConfiguration : IEntityTypeConfiguration<GamePlatform>
{
    public void Configure(EntityTypeBuilder<GamePlatform> builder)
    {
        // Composite Primary Key
        builder.HasKey(gp => new { gp.GameId, gp.PlatformId });

        // Relationships
        builder.HasOne(gp => gp.Game)
               .WithMany(g => g.GamePlatforms)
               .HasForeignKey(gp => gp.GameId);

        builder.HasOne(gp => gp.Platform)
               .WithMany(p => p.GamePlatforms)
               .HasForeignKey(gp => gp.PlatformId);
    }
}