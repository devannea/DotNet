using ExerciseLogAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseLogAPI.Infrastructure.Data
{
    class ActivityRepository
    {
        private readonly AppDbContext _dbContext;

        public ActivityRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Activity Add(Activity activity)
        {
            _dbContext.Activities.Add(activity);
            _dbContext.SaveChanges();
            return activity;
        }

        public Activity Get(int id)
        {
            return _dbContext.Activities
                .SingleOrDefault(u => u.Id == id);
        }

        public IEnumerable<Activity> GetAll()
        {
            return _dbContext.Activities
                .ToList();
        }

        public Activity Update(Activity updatedActivity)
        {
            var currentActivity = _dbContext.Activities.Find(updatedActivity.Id);

            if (currentActivity == null) return null;

            _dbContext.Entry(currentActivity)
                .CurrentValues
                .SetValues(updatedActivity);

            _dbContext.Activities.Update(currentActivity);
            _dbContext.SaveChanges();
            return currentActivity;
        }

        public void Remove(Activity activity)
        {
            _dbContext.Activities.Remove(activity);
            _dbContext.SaveChanges();
        }
    }
}
