// Purpose: contains DbSet properties for entities and configures database relationships, constraints, and indexes.

using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Text> Texts { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
    }
}