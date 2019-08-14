using System;
using System.Collections.Generic;
using CS321_W4D2_ExerciseLogAPI.Core.Models;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public interface IUserRepository
    {
        // CRUDL - create (add), read (get), update, delete (remove), list

        // create
        User Add(User todo);
        // read
        User Get(int id);
        // update
        User Update(User todo);
        // delete
        void Remove(User todo);
        // list
        IEnumerable<User> GetAll();
    }
}
