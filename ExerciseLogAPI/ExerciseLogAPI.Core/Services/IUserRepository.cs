using CS321_W4D2_ExerciseLogAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public interface IUserRepository
    {
        // Create
        User Add(User todo);
        // Read
        User Get(int id);
        // Update
        User Update(User todo);
        // Delete
        void Remove(User todo);
        // List
        IEnumerable<User> GetAll();
    }
}
