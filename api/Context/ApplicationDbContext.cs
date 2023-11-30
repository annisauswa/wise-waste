using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Sell> Sell { get; set; }
    }
}
