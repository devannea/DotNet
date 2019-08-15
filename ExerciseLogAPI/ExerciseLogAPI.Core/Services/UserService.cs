using System;
using System.Collections.Generic;
using System.Text;
using ExerciseLogAPI.Core.Models;

namespace ExerciseLogAPI.Core.Services
{
    class UserService : IUserService
    {
        private IUserRepository _userRepo;

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public User Add(User User)
        {
            // TODO: implement add
            _userRepo.Users.Add(User);
            _userRepo.SaveChanges();
            return User;
        }

    }
}
