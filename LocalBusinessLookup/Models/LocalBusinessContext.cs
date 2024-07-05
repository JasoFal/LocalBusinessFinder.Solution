using Microsoft.EntityFrameworkCore;

namespace LocalBusiness.Models
{
  public class LocalBusinessContext : DbContext
  {
    public DbSet<Business> Businesses { get; set; }

    public LocalBusinessContext(DbContextOptions<LocalBusinessContext> options) : base(options)
    {
    }
  }
}