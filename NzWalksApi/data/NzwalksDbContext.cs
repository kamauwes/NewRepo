using Microsoft.EntityFrameworkCore;
using NzWalksApi.Models.Domains;

namespace NzWalksApi.data
{
    public class NzwalksDbContext : DbContext
    {
        public NzwalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<walk> Walks { get; set; }
    }
    
    
}
