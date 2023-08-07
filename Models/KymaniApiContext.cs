using Microsoft.EntityFrameworkCore;

namespace KymaniApi.Models
{
  public class KymaniApiContext : DbContext
  {
    public DbSet<Kymani> Kymanis { get; set; }
    public KymaniApiContext(DbContextOptions<KymaniApiContext> options) : base(options) {}
  }
}