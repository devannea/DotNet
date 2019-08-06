using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPI.Models;

namespace BookAPI.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        Book Get(int Id);
        Book Add(Book newBook);
        Book Update(Book updatedBook);
        void Delete(Book book);
    }
}
