using System.Collections.Generic;
using System.Linq;
using CS321_W4D1_BookAPI.Data;
using CS321_W4D1_BookAPI.Models;
using CS321_W4D1_BookAPI.Services;

namespace CS321_W4D1_BookAPI.Services
{
    public class AuthorService : IAuthorService
    {

        private readonly BookContext _bookContext;

        public AuthorService(BookContext bookContext)
        {
            // TODO: keep a reference to the AuthorContext in _AuthorContext
            _bookContext = bookContext;
        }

        public Author Add(Author Author)
        {
            // TODO: implement add
            _bookContext.Authors.Add(Author);
            _bookContext.SaveChanges();
            return Author;
        }

        public Author Get(int id)
        {
            // TODO: return the specified Author using Find()
            return _bookContext.Authors.Find(id);
        }

        public IEnumerable<Author> GetAll()
        {
            // TODO: return all Authors using ToList()
            return _bookContext.Authors.ToList();
        }

        public Author Update(Author updatedAuthor)
        {
            // get the ToDo object in the current list with this id 
            var currentAuthor = _bookContext.Authors.Find(updatedAuthor.Id);

            // return null if todo to update isn't found
            if (currentAuthor == null) return null;

            // NOTE: This method is already completed for you, but note
            // how the property values are copied below.

            // copy the property values from the changed todo into the
            // one in the db. NOTE that this is much simpler than individually
            // copying each property.
            _bookContext.Entry(currentAuthor)
                .CurrentValues
                .SetValues(updatedAuthor);

            // update the todo and save
            _bookContext.Authors.Update(currentAuthor);
            _bookContext.SaveChanges();
            return currentAuthor;
        }

        public void Remove(Author Author)
        {
            // TODO: remove the Author
            _bookContext.Authors.Remove(Author);
            _bookContext.SaveChanges();
        }

    }
}
