namespace Library.Data
{
    using Library.Models;
    using Microsoft.EntityFrameworkCore;

    public class LibraryDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        private const string ConnectionString = @"Server=localhost\SQLEXPRESS;Database=Books;Trusted_Connection=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
