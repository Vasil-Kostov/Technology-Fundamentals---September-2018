using BandRegister.Models;
using Microsoft.EntityFrameworkCore;

namespace BandRegister.Data
{
    public class BandRegisterDbContext : DbContext
    {
        public DbSet<Band> Bands { get; set; }

        private const string ConnectionString = @"Server=localhost\SQLEXPRESS;Database=BandRegister;Trusted_Connection=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
