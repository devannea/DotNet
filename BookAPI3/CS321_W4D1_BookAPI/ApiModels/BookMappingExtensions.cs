using CS321_W4D1_BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CS321_W4D1_BookAPI.ApiModels
{
    public static class BookMappingExtenstions
    {

        public static BookModel ToApiModel(this Book book)
        {
             // return a new BookModel and copy the
             // property values over from the Book
             return new BookModel
             {
                 Id = book.Id,
                 Title = book.Title,
                 Genre = book.Genre,
                 OriginalLanguage = book.OriginalLanguage,
                 PublicationYear = book.PublicationYear,
                 PublisherId = book.PublisherId,
                 AuthorId = book.AuthorId,
                 // concatenate the author's name properties and use it as the value of
                 // Author. Use null if the Author is null.
                 Author = book.Author == null
                     ? null
                     : book.Author.LastName + ", " + book.Author.FirstName,
                 Publisher = book.Publisher == null
                     ? null
                     : book.Publisher.Name + ", " + book.Publisher.City
             };
        }

        public static Book ToDomainModel(this BookModel bookModel)
        {
             // return a new Book domain object and copy the
             // property values over from the BookModel
             return new Book
             {
                 Id = bookModel.Id,
                 Title = bookModel.Title,
                 Genre = bookModel.Genre,
                 OriginalLanguage = bookModel.OriginalLanguage,
                 PublicationYear = bookModel.PublicationYear,
                 PublisherId = bookModel.PublisherId,
                 AuthorId = bookModel.AuthorId,
                 // Note that we don't set the Publisher or Author object properties. 
                 // Setting the PublisherId and AuthorId fields is enough.
             };
        }

        public static IEnumerable<BookModel> ToApiModels(this IEnumerable<Book> authors)
        {
            return authors.Select(a => a.ToApiModel());
        }

        public static IEnumerable<Book> ToDomainModel(this IEnumerable<BookModel> authorModels)
        {
            return authorModels.Select(a => a.ToDomainModel());
        }
    }
}
