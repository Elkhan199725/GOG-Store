using GOG.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Configurations;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        // Primary Key
        builder.HasKey(c => c.Id);

        // Properties
        builder.Property(c => c.Content)
               .IsRequired();

        builder.Property(c => c.PostedDate)
               .IsRequired();

        builder.Property(c => c.Likes)
               .HasDefaultValue(0);

        builder.Property(c => c.Dislikes)
               .HasDefaultValue(0);

        // Relationships
        builder.HasOne(c => c.Game)
               .WithMany(g => g.Comments)
               .HasForeignKey(c => c.GameId);

        builder.HasOne(c => c.User)
               .WithMany(u => u.Comments)
               .HasForeignKey(c => c.UserId);

        builder.HasOne(c => c.ParentComment)
               .WithMany(pc => pc.Replies)
               .HasForeignKey(c => c.ParentCommentId)
               .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete of replies when a parent comment is deleted

        // Indexes
        builder.HasIndex(c => c.PostedDate); // Index on PostedDate for faster querying by date
    }
}
