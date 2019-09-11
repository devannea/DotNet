using CS321_W4D2_ExerciseLogAPI.Core.Models;
using CS321_W4D2_ExerciseLogAPI.Core.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS321_W4D2_ExerciseLogAPI.Infrastructure.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User Add(User User)
        {
            _dbContext.Users.Add(User);
            _dbContext.SaveChanges();
            return User;
        }
        public User Get(int id)
        {
            var user = _dbContext.Users
                        .Include(u => u.Activities)
                        .ThenInclude(activity => activity.ActivityType)
                        .FirstOrDefault(u => u.Id == id);
            if (user == null) return null;
            return user;
        }
        public User Update(User updatedUser)
        {
            var currentUser = _dbContext.Users.FirstOrDefault(u => u.Id == updatedUser.Id);
            if (currentUser == null) return null;

            _dbContext.Entry(currentUser).CurrentValues.SetValues(updatedUser);
            _dbContext.Update(currentUser);
            _dbContext.SaveChanges();
            return currentUser;
        }
        public void Remove(User User)
        {
            _dbContext.Users.Remove(User);
            _dbContext.SaveChanges();
        }
        public IEnumerable<User> GetAll()
        {
            return _dbContext.Users.ToList();
        }
    }
}
