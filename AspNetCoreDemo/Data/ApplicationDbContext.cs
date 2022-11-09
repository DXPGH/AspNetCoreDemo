using AspNetCoreDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreDemo.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // Category model => Table Categories

        // Create TABle...

        public DbSet<Category> Categories { get; set; }
    }
}
