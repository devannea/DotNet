using CS321_W3D1_BookAPI.Models;
using CS321_W3D1_BookAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CS321_W3D1_BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        // Constructor
        public BooksController(/* TODO: inject IBookService */)
        {
            // TODO: keep a reference to the service so we can use below
        }

        // TODO: get all books
        // GET api/books

        // get specific book by id
        // GET api/books/:id

        // create a new book
        // POST api/books
        [HttpPost]
        public IActionResult Post([FromBody] Book newBook)
        {
            try
            {
                // add the new book
                _bookService.Add(newBook);
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("AddBook", ex.Message);
                return BadRequest(ModelState);
            }

            // return a 201 Created status. This will also add a "location" header
            // with the URI of the new book. E.g., /api/books/99, if the new is 99
            return CreatedAtAction("Get", new { Id = newBook.Id }, newBook);
        }

        // TODO: update an existing book
        // PUT api/books/:id

        // TODO: delete an existing book
        // DELETE api/books/:id
    }
}
