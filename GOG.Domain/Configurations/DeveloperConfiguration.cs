using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Configurations;

using GOG.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class DeveloperConfiguration : IEntityTypeConfiguration<Developer>
{
    public void Configure(EntityTypeBuilder<Developer> builder)
    {
        // Primary Key
        builder.HasKey(d => d.Id);

        // Properties
        builder.Property(d => d.Name)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(d => d.Location)
               .HasMaxLength(255); 

        builder.Property(d => d.Website)
               .HasMaxLength(255); 

        builder.Property(d => d.ContactEmail)
               .HasMaxLength(100); 

        // Relationships
        builder.HasMany(d => d.Games)
               .WithOne(g => g.Developer)
               .HasForeignKey(g => g.DeveloperId);

        // Indexes
        builder.HasIndex(d => d.Name); // Index on name for faster querying
        builder.HasIndex(d => d.ContactEmail).IsUnique(); // Ensure unique email addresses if used for contact purposes
    }
}
