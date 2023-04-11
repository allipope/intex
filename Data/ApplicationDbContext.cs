using intex.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace intex.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //public DbSet<mummy> ?burialmain { get; set; }
        //public DbSet<textile> ?textile { get; set; }
        //public DbSet<burialmain_textile> ?burialmain_textile { get; set; }
        //public DbSet<color_textile> ?color_textile { get; set; }
        //public DbSet<color> ?color { get; set; }
    }
}