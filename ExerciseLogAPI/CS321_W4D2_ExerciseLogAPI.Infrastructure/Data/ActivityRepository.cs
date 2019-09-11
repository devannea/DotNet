using CS321_W4D2_ExerciseLogAPI.Core.Models;
using CS321_W4D2_ExerciseLogAPI.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS321_W4D2_ExerciseLogAPI.Infrastructure.Data
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly AppDbContext _dbContext;

        public ActivityRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Activity Add(Activity Activity)
        {
            _dbContext.Activities.Add(Activity);
            _dbContext.SaveChanges();
            return Activity;
        }
        public Activity Get(int id)
        {
            var activity = _dbContext.Activities.FirstOrDefault(u => u.Id == id);
            if (activity == null) return null;
            return activity;
        }
        public Activity Update(Activity updatedActivity)
        {
            var currentActivity = _dbContext.Activities.FirstOrDefault(u => u.Id == updatedActivity.Id);
            if (currentActivity == null) return null;

            _dbContext.Entry(currentActivity).CurrentValues.SetValues(updatedActivity);
            _dbContext.Update(currentActivity);
            _dbContext.SaveChanges();
            return currentActivity;
        }
        public void Remove(Activity Activity)
        {
            _dbContext.Activities.Remove(Activity);
            _dbContext.SaveChanges();
        }
        public IEnumerable<Activity> GetAll()
        {
            return _dbContext.Activities.ToList();
        }
    }
}
