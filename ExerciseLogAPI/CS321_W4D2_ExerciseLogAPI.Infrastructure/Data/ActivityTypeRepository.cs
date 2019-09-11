using CS321_W4D2_ExerciseLogAPI.Core.Models;
using CS321_W4D2_ExerciseLogAPI.Core.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS321_W4D2_ExerciseLogAPI.Infrastructure.Data
{
    class ActivityTypeRepository : IActivityTypeRepository
    {
        private readonly AppDbContext _dbContext;

        public ActivityTypeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ActivityType Add(ActivityType ActivityType)
        {
            _dbContext.ActivityTypes.Add(ActivityType);
            _dbContext.SaveChanges();
            return ActivityType;
        }
        public ActivityType Get(int id)
        {
            var activityType = _dbContext.ActivityTypes.FirstOrDefault(u => u.Id == id);
            if (activityType == null) return null;
            return activityType;
        }
        public ActivityType Update(ActivityType updatedActivityType)
        {
            var currentActivityType = _dbContext.ActivityTypes.FirstOrDefault(u => u.Id == updatedActivityType.Id);
            if (currentActivityType == null) return null;

            _dbContext.Entry(currentActivityType).CurrentValues.SetValues(updatedActivityType);
            _dbContext.Update(currentActivityType);
            _dbContext.SaveChanges();
            return currentActivityType;
        }
        public void Remove(ActivityType ActivityType)
        {
            _dbContext.ActivityTypes.Remove(ActivityType);
            _dbContext.SaveChanges();
        }
        public IEnumerable<ActivityType> GetAll()
        {
            return _dbContext.ActivityTypes.ToList();
        }
    }
}
