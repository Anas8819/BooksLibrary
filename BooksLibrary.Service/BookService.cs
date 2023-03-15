using BooksLibrary.Core.Entities;
using BooksLibrary.Core.IService;
using BooksLibrary.EF.EFCore;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Service
{
    public class BookService : IBookService
    {
        public async Task<bool> AddNewBook(Book book)
        {
            var db = new BookLibraryDBContext();

            db.Books.Add(book);

            var result = await db.SaveChangesAsync();

            return result > 0;
        }

        public async Task<List<Book>> GetBooksList()
        {
            var db = new BookLibraryDBContext();

            var result = await db.Books.ToListAsync();

            return result;
        }
    }
}
