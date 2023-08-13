using Microsoft.EntityFrameworkCore;

namespace Docker.Backend_app
{
    public class KibongaDbContext : DbContext
    {
        public KibongaDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
