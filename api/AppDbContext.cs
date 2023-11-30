using Microsoft.EntityFrameworkCore;
using System;
using api.Models;

namespace api
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Sell> Sell { get; set; }
    }
}
