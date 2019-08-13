using CS321_W3D2_BookAPI.Models;
using CS321_W3D2_BookAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CS321_W3D2_BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        // Constructor
        public AuthorsController(IAuthorService authorService)
        {
            // TODO: keep a reference to the service so we can use below
            _authorService = authorService;
        }

        // TODO: get all authors
        // GET api/authors
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_authorService.GetAll());
        }

        // get specific author by id
        // GET api/authors/:id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var author = _authorService.Get(id);
            if (author == null) return NotFound();
            return Ok(author);
        }

        // create a new author
        // POST api/authors
        [HttpPost]
        public IActionResult Post([FromBody] Author newAuthor)
        {
            try
            {
                // add the new author
                _authorService.Add(newAuthor);
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("AddAuthor", ex.GetBaseException().Message);
                return BadRequest(ModelState);
            }

            // return a 201 Created status. This will also add a "location" header
            // with the URI of the new author. E.g., /api/authors/99, if the new is 99
            return CreatedAtAction("Get", new { Id = newAuthor.Id }, newAuthor);
        }

        // TODO: update an existing author
        // PUT api/authors/:id
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Author updatedAuthor)
        {
            var author = _authorService.Update(updatedAuthor);
            if (author == null) return NotFound();
            return Ok(author);
        }

        // TODO: delete an existing author
        // DELETE api/authors/:id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var author = _authorService.Get(id);
            if (author == null) return NotFound();
            _authorService.Remove(author);
            return NoContent();
        }
    }
}
