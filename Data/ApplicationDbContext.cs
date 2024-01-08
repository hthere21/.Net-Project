using Microsoft.EntityFrameworkCore;
using Project_.Net_6.Models;

namespace Project_.Net_6.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
    }
}
