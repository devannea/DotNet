using System;
using System.Collections.Generic;
using System.Text;
using ExerciseLogAPI.Core.Services;

namespace ExerciseLogAPI.Infrastructure.Data
{
    class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


    }
}
