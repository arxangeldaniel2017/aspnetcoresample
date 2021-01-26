using Microsoft.EntityFrameworkCore;
using aspnetapp.Model;

namespace aspnetapp.Database {
    public class AppDbContext : DbContext {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }

        public DbSet<Test> Tests { get; set; }
    }
}