using CS321_W4D2_ExerciseLogAPI.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CS321_W4D2_ExerciseLogAPI.ApiModels;
using CS321_W4D2_ExerciseLogAPI.Core.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CS321_W4D2_ExerciseLogAPI.Controllers
{
    [Route("api/[controller]")]
    public class ActivitiesController : ControllerBase
    {
        private IActivityService _activityService;

        public ActivitiesController(IActivityService activityService)
        {
            _activityService = activityService;
        }
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_activityService.GetAll().ToApiModels());
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var activity = _activityService.Get(id).ToApiModel();
            if (activity == null) return NotFound();
            return Ok(activity);
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody] ActivityModel activity)
        {
            try
            {
                _activityService.Add(activity.ToDomainModel());
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("AddActivity", ex.Message);
                return BadRequest(ModelState);
            }
            return CreatedAtAction("Get", new { Id = activity.Id }, activity);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ActivityModel activity)
        {
            activity.Id = id;
            var currentActivity = _activityService.Update(activity.ToDomainModel());
            if (currentActivity == null) return NotFound();
            return Ok(currentActivity);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var activity = _activityService.Get(id);
            if (activity == null) return NotFound();
            _activityService.Remove(activity);
            return NoContent();
        }
    }
}
