using BooksLibrary.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary.Core.IService
{
    public interface IBookService
    {
        public Task<List<Book>> GetBooksList();
        public Task<bool> AddNewBook(Book book);
    }
}
