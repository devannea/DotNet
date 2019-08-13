using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS321_W4D1_BookAPI.Models;
using CS321_W4D1_BookAPI.ApiModels;
using CS321_W4D1_BookAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CS321_W4D1_BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private readonly IPublisherService _publisherService;

        // Constructor
        public PublishersController(IPublisherService publisherService)
        {
            // TODO: keep a reference to the service so we can use below
            _publisherService = publisherService;
        }

        // TODO: get all publishers
        // GET api/publishers
        [HttpGet]
        public IActionResult Get()
        {
            // TODO: return ApiModels instead of domain models
            var publisherModels = _publisherService
                .GetAll()
                .ToApiModels();
            return Ok(publisherModels);
        }

        // get specific publisher by id
        // GET api/publishers/:id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // TODO: return ApiModel instead of domain model
            var publisher = _publisherService
                .Get(id)
                .ToApiModel();
            if (publisher == null) return NotFound();
            return Ok(publisher);
        }

        // create a new publisher
        // POST api/publishers
        [HttpPost]
        public IActionResult Post([FromBody] PublisherModel newPublisher)
        {
            try
            {
                // TODO: convert the newPublisher to a domain model
                // add the new publisher
                _publisherService.Add(newPublisher.ToDomainModel());
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("AddPublisher", ex.GetBaseException().Message);
                return BadRequest(ModelState);
            }

            // return a 201 Created status. This will also add a "location" header
            // with the URI of the new publisher. E.g., /api/publishers/99, if the new is 99
            return CreatedAtAction("Get", new { Id = newPublisher.Id }, newPublisher);
        }

        // TODO: update an existing publisher
        // PUT api/publishers/:id
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] PublisherModel updatedPublisher)
        {
            // TODO: convert updatedPublisher to a domain model
            var publisher = _publisherService.Update(updatedPublisher.ToDomainModel());
            if (publisher == null) return NotFound();
            return Ok(publisher);
        }

        // TODO: delete an existing publisher
        // DELETE api/publishers/:id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var publisher = _publisherService.Get(id);
            if (publisher == null) return NotFound();
            _publisherService.Remove(publisher);
            return NoContent();
        }
    }
}
