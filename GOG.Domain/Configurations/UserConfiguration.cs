using GOG.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        // Primary Key
        builder.HasKey(u => u.Id);

        // Properties
        builder.Property(u => u.Username)
               .IsRequired()
               .HasMaxLength(50);

        builder.Property(u => u.Email)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(u => u.PasswordHash)
               .IsRequired();

        builder.Property(u => u.ProfilePictureUrl)
               .HasMaxLength(255);

        // Relationships
        builder.HasMany(u => u.Comments)
               .WithOne(c => c.User)
               .HasForeignKey(c => c.UserId);

        builder.HasMany(u => u.MediaItems)
               .WithOne()
               .HasForeignKey(m => m.MediaOwnerId)
               .OnDelete(DeleteBehavior.Cascade);

        // Indexes
        builder.HasIndex(u => u.Email).IsUnique();
        builder.HasIndex(u => u.Username).IsUnique();
    }
}