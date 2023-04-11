using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace intex.Models
{
    public class MummyContext : DbContext
    {
        public MummyContext(DbContextOptions<MummyContext> options) : base(options) 
        {
            // leave blank for now
        }

        public DbSet<mummy> burialmain { get; set; }
        public DbSet<textile> textile { get; set; }
        public DbSet<burialmain_textile> burialmain_textile { get; set; }
        public DbSet<color_textile> color_textile { get; set; }
        public DbSet<color> color { get; set; }
    }
}
