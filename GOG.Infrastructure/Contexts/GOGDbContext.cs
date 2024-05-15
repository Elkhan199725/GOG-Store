using GOG.Domain.Configurations;
using GOG.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Infrastructure.Contexts;

public class GOGDbContext : DbContext
{
    public GOGDbContext(DbContextOptions<GOGDbContext> options) : base(options) { }

    public DbSet<Game> Games { get; set; }
    public DbSet<Developer> Developers { get; set;}
    public DbSet<Comment> Comments { get; set; }
    public DbSet<GameGenre> GameGenres { get; set; }
    public DbSet<GamePlatform> GamePlatforms { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Media> MediaItems { get; set; }
    public DbSet<Platform> Platforms { get; set; }
    public DbSet<User> Users { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new GameConfiguration());
        modelBuilder.ApplyConfiguration(new GameGenreConfiguration());
        modelBuilder.ApplyConfiguration(new GenreConfiguration());
        modelBuilder.ApplyConfiguration(new GamePlatformConfiguration());
        modelBuilder.ApplyConfiguration(new DeveloperConfiguration());
        modelBuilder.ApplyConfiguration(new CommentConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new PlatformConfiguration());
        modelBuilder.ApplyConfiguration(new MediaConfiguration());
        modelBuilder.ApplyConfiguration(new GameRequirementConfiguration());
        modelBuilder.ApplyConfiguration(new NewsArticleConfiguration());
        modelBuilder.ApplyConfiguration(new NewsCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new NewsTagConfiguration());
        modelBuilder.ApplyConfiguration(new NewsArticleCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new NewsArticleTagConfiguration());
    }
}
