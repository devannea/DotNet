using System;
using System.Collections.Generic;
using CS321_W4D2_ExerciseLogAPI.Core.Models;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepo;

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public User Add(User User)
        {
            // TODO: implement add
            _userRepo.Add(User);
            return User;
        }

        public User Get(int id)
        {
            // TODO: return the specified User using Find()
            return _userRepo.Get(id);
        }

        public IEnumerable<User> GetAll()
        {
            // TODO: return all Users using ToList()
            return _userRepo.GetAll();
        }

        public User Update(User updatedUser)
        {
            // update the todo and save
            var User = _userRepo.Update(updatedUser);
            return User;
        }

        public void Remove(User User)
        {
            // TODO: remove the User
            _userRepo.Remove(User);
        }

    }


}
