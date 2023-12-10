using Microsoft.EntityFrameworkCore;
using Project.API.Model.Domain;

namespace Project.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
