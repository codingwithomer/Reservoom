using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Reservoom.DbContexts
{
    public class ReservoomDesignTimeDbContextFactory : IDesignTimeDbContextFactory<ReservoomDbContext>
    {
        public ReservoomDbContext CreateDbContext(string[] args)
        {
            DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseSqlite("Data Source=reservoom.db").Options;

            return new ReservoomDbContext(dbContextOptions);
        }
    }
}
