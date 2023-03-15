using BooksLibrary.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace BooksLibrary.EF.EFCore
{
    public class BookLibraryDBContext : DbContext
    {
        public BookLibraryDBContext()
        {

        }

        public BookLibraryDBContext(DbContextOptions<BookLibraryDBContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=BookLibrary;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


    }
}
