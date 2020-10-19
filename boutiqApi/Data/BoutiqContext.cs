using boutiq.Models;
using Microsoft.EntityFrameworkCore;

namespace boutiq.Data
{
    public class BoutiqContext : DbContext
    {
        public BoutiqContext(DbContextOptions<BoutiqContext> options) : base(options)
        {

        }
        public DbSet<Boutiq> Boutiqs { get; set; }
    }
}