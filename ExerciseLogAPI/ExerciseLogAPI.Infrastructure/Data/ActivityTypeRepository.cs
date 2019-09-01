using ExerciseLogAPI.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseLogAPI.Infrastructure.Data
{
    class ActivityTypeRepository
    {
        private readonly AppDbContext _dbContext;

        public ActivityTypeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ActivityType Add(ActivityType activityType)
        {
            _dbContext.ActivityTypes.Add(activityType);
            _dbContext.SaveChanges();
            return activityType;
        }

        public ActivityType Get(int id)
        {
            return _dbContext.ActivityTypes
                .SingleOrDefault(u => u.Id == id);
        }

        public IEnumerable<ActivityType> GetAll()
        {
            return _dbContext.ActivityTypes
                .ToList();
        }

        public ActivityType Update(ActivityType updatedActivityType)
        {
            var currentActivityType = _dbContext.ActivityTypes.Find(updatedActivityType.Id);

            if (currentActivityType == null) return null;

            _dbContext.Entry(currentActivityType)
                .CurrentValues
                .SetValues(updatedActivityType);

            _dbContext.ActivityTypes.Update(currentActivityType);
            _dbContext.SaveChanges();
            return currentActivityType;
        }

        public void Remove(ActivityType activityType)
        {
            _dbContext.ActivityTypes.Remove(activityType);
            _dbContext.SaveChanges();
        }
    }
}
