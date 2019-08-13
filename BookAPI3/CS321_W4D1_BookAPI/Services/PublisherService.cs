using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS321_W4D1_BookAPI.Data;
using CS321_W4D1_BookAPI.Models;
using CS321_W4D1_BookAPI.Services;
using Microsoft.EntityFrameworkCore;


namespace CS321_W4D1_BookAPI.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly BookContext _bookContext;

        public PublisherService(BookContext bookContext)
        {
            // TODO: keep a reference to the AuthorContext in _AuthorContext
            _bookContext = bookContext;
        }

        public Publisher Add(Publisher Publisher)
        {
            // TODO: implement add
            _bookContext.Publishers.Add(Publisher);
            _bookContext.SaveChanges();
            return Publisher;
        }

        public Publisher Get(int id)
        {
            // TODO: return the specified Author using Find()
            return _bookContext.Publishers.Find(id);
        }

        public IEnumerable<Publisher> GetAll()
        {
            // TODO: return all Authors using ToList()
            return _bookContext.Publishers.ToList();
        }

        public Publisher Update(Publisher updatedPublisher)
        {
            // get the ToDo object in the current list with this id 
            var currentPublisher = _bookContext.Publishers.Find(updatedPublisher.Id);

            // return null if todo to update isn't found
            if (currentPublisher == null) return null;

            // NOTE: This method is already completed for you, but note
            // how the property values are copied below.

            // copy the property values from the changed todo into the
            // one in the db. NOTE that this is much simpler than individually
            // copying each property.
            _bookContext.Entry(currentPublisher)
                .CurrentValues
                .SetValues(updatedPublisher);

            // update the todo and save
            _bookContext.Publishers.Update(currentPublisher);
            _bookContext.SaveChanges();
            return currentPublisher;
        }

        public void Remove(Publisher Publisher)
        {
            // TODO: remove the Author
            _bookContext.Publishers.Remove(Publisher);
            _bookContext.SaveChanges();
        }
    }
}
