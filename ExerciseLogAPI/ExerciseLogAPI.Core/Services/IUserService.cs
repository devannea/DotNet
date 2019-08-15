using System;
using System.Collections.Generic;
using System.Text;
using ExerciseLogAPI.Core.Models;

namespace ExerciseLogAPI.Core.Services
{
    interface IUserService
    {
        User Add(User todo);
    }
}
