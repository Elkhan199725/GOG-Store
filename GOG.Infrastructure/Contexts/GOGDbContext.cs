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
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
