using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using CS321_W5D1_ExerciseLogAPI.Core.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CS321_W5D1_ExerciseLogAPI.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly UserManager<User> _userManager;

        // TODO: Prep Part 1: add constructor and inject UserManager 

        // TODO: Prep Part 2: inject IConfiguration in the constructor

        // TODO: Prep Part 1: Add a Registration Action (Part 1 of Prep exercise)

        // TODO: Prep Part 2: Add a login action (Part 2 of Prep exercise)

    }
}
