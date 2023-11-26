﻿using Microsoft.EntityFrameworkCore;

namespace Reservoom.DbContexts
{
    public class ReservoomDbContextFactory
    {
        private readonly string _connectionString;

        public ReservoomDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ReservoomDbContext CreateDbContext()
        {
            DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseSqlite(_connectionString).Options;

            return new ReservoomDbContext(dbContextOptions);
        }
    }
}
