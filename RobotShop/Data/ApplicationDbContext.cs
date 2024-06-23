using Microsoft.EntityFrameworkCore;
using RobotShop.Models;

namespace RobotShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        } 
        public DbSet<Brand> Brand { get; set; }
    }
}
