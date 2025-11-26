using Esakay.Models;
using Microsoft.EntityFrameworkCore;

namespace Esakay.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}