using Microsoft.EntityFrameworkCore;
using PurpleBuzzWebApp.Models;

namespace PurpleBuzzWebApp.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
        public DbSet<Slider>Sliders { get; set; }
        public DbSet<Client> Clients{ get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
