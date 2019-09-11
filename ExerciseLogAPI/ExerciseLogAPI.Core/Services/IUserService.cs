using System.Collections.Generic;
using CS321_W4D2_ExerciseLogAPI.Core.Models;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
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