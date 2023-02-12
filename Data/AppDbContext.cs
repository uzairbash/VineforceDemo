using Microsoft.EntityFrameworkCore;
using VineForceDemo.Models;

namespace VineForceDemo.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Country>? Countries { get; set; }
        public DbSet<State>? States { get; set; }

    }
}
