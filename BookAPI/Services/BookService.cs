using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPI.Models;
using BookAPI.Data;

namespace BookAPI.Services
{
    public class BookService : IBookService
    {
        private readonly BookContext _bookContext;

        public BookService(BookContext bookContext)
        {
            _bookContext = bookContext;
        }

        // Get all books
        public IEnumerable<Book> GetAll()
        {
            return _bookContext.books.ToList();
        }

        // Get a book by ID
        public Book Get(int Id)
        {
            return _bookContext.books.Find(Id);
        }

        // Add a new book
        public Book Add(Book newBook)
        {
            _bookContext.books.Add(newBook);
            _bookContext.SaveChanges();
            return newBook;
        }

        // Update a book
        public Book Update(Book updatedBook)
        {
            var currentBook = _bookContext.books.FirstOrDefault(b => b.Id == updatedBook.Id);
            if (currentBook == null) return null;
            _bookContext.Entry(currentBook).CurrentValues.SetValues(updatedBook);
            _bookContext.Update(currentBook);
            _bookContext.SaveChanges();
            return currentBook;
        }

        // Delete a book
        public void Delete(Book book)
        {
            var currentBook = _bookContext.books.Find(book.Id);
            if (currentBook != null)
            {
                _bookContext.books.Remove(book);
                _bookContext.SaveChanges();
            }
        }
    }
}
