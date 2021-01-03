using System;
using Microsoft.EntityFrameworkCore;

namespace loosely_coupled.DataAccessLayer
{
    public class CommerceContext : DbContext
    {
        private readonly string _connectionString;
        
        public DbSet<Product> Products { get; set; }

        public CommerceContext(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException("connection string should not be null");

            this._connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            // builder.UseSqlServer(this.connectionString);
        }
    }
}