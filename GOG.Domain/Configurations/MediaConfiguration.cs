using GOG.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Configurations;

public class MediaConfiguration : IEntityTypeConfiguration<Media>
{
    public void Configure(EntityTypeBuilder<Media> builder)
    {
        // Primary Key
        builder.HasKey(m => m.Id);

        // Properties
        builder.Property(m => m.Url)
               .IsRequired()
               .HasMaxLength(2048); // Setting a reasonable max length for URLs

        builder.Property(m => m.MediaType)
               .IsRequired();

        builder.Property(m => m.IsCover)
               .IsRequired();

        builder.Property(m => m.MediaOwnerType)
               .IsRequired();

        builder.Property(m => m.MediaOwnerId)
               .IsRequired();

        // Indexes
        builder.HasIndex(m => new { m.MediaOwnerId, m.MediaOwnerType, m.IsCover })
               .IsUnique()
               .HasFilter("[IsCover] = 1"); // Ensuring there is only one cover image per owner
    }
}