using Microsoft.EntityFrameworkCore;
using SayaraCar.Models;

namespace SayaraCar.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<BannerModel> BannerModels { get; set; }
        public DbSet<BannerType> BannerTypes { get; set; }
        public DbSet<BannerColor> BannerColors { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Preview> Previews { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Bio> Bios { get; set; }
    }
}
