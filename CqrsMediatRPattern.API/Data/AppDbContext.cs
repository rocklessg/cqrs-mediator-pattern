using CqrsMediatRPattern.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CqrsMediatRPattern.API.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
           Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Student> Students { get; set; }
    }
}
