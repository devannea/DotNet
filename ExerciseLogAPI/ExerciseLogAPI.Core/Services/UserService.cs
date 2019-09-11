using CS321_W4D2_ExerciseLogAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
            return _userRepo.Add(User);
        }
        public User Get(int id)
        {
            var userId = _userRepo.Get(id);
            return userId;
        }
        public User Update(User updatedUser)
        {
            var currentUser = _userRepo.Update(updatedUser);
            return currentUser;
        }
        public void Remove(User User)
        {
            _userRepo.Remove(User);
        }
        public IEnumerable<User> GetAll()
        {
            return _userRepo.GetAll();
        }
    }
}
