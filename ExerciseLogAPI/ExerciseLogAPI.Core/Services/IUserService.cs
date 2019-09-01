using System;
using System.Collections.Generic;
using System.Text;
using ExerciseLogAPI.Core.Models;

namespace ExerciseLogAPI.Core.Services
{
    public interface IUserService
    {
        User Add(User User);
        User Get(int id);
        IEnumerable<User> GetAll();
        void Remove(User User);
        User Update(User updatedUser);
    }
}
