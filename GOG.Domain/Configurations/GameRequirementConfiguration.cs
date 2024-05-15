using GOG.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Configurations;

public class GameRequirementConfiguration : IEntityTypeConfiguration<GameRequirement>
{
    public void Configure(EntityTypeBuilder<GameRequirement> builder)
    {
        // Primary Key
        builder.HasKey(gr => gr.Id);

        // Properties
        builder.Property(gr => gr.OS)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(gr => gr.Processor)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(gr => gr.Memory)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(gr => gr.Graphics)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(gr => gr.Storage)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(gr => gr.AdditionalNotes)
               .HasMaxLength(500);

        builder.Property(gr => gr.RequirementType)
               .IsRequired();

        // Relationships
        builder.HasOne(gr => gr.Game)
               .WithMany(g => g.GameRequirements)
               .HasForeignKey(gr => gr.GameId);

        // Indexes
        builder.HasIndex(gr => new { gr.GameId, gr.RequirementType }).IsUnique();
    }
}
