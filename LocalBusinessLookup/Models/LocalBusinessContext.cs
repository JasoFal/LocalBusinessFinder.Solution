using Microsoft.EntityFrameworkCore;

namespace LocalBusiness.Models
{
  public class LocalBusinessContext : DbContext
  {
    public DbSet<Business> Businesses { get; set; }

    public LocalBusinessContext(DbContextOptions<LocalBusinessContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
        .HasData(
          new Business { BusinessId = 1, Name = "Jim's Roadhouse", Type = "Restaurant", Description = "BBQ of all forms!"},
          new Business { BusinessId = 2, Name = "Terry's Tools", Type = "Shop", Description = "We got all kinds of tools!"},
          new Business { BusinessId = 3, Name = "Parker's Place", Type = "Place", Description = "Don't step foot in the place."}
      );
    }
  }
}