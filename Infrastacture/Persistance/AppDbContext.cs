using Microsoft.EntityFrameworkCore;
using Domain.Entities; // your entities namespace

namespace Infrastacture.Persistance
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<tbl_users> Users { get; set; }
    }
}
