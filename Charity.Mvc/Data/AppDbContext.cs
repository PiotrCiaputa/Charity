using Charity.Mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Charity.Mvc.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Institution> Institutions { get; set; }
    }
}
