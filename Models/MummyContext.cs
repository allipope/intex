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
    }
}
