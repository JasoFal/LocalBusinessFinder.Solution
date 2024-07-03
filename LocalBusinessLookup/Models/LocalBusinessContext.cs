using Microsoft.EntityFrameworkCore;

namespace LocalBusiness.Models
{
  public class LocalBusinessContext : DbContext
  {
    public DbSet<Message> Messages { get; set; }

    public LocalBusinessContext(DbContextOptions<LocalBusinessContext> options) : base(options)
    {
    }
  }
}