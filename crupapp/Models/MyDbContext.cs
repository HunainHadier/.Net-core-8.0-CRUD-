using Microsoft.EntityFrameworkCore;

namespace crupapp.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> contextOptions) : base(contextOptions) { 
        
        }

        public DbSet<UserReg> Users { get; set; }

    }
}
