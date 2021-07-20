using System.Linq;
using System.Threading.Channels;
using Microsoft.EntityFrameworkCore;

namespace HotelsAPI.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }
        
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Name = "Nigeria",
                    ShortName = "NG"
                },
                new Country
                {
                    Name = "Ghana",
                    ShortName = "GH"
                },
                new Country
                {
                    Name = "South Africa",
                    ShortName = "RSA"
                });
        }
        
        
    }
}