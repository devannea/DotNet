using CS321_W4D2_ExerciseLogAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public class ActivityService : IActivityService
    {
        private IActivityRepository _activityRepo;

        public ActivityService(IActivityRepository activityRepo)
        {
            _activityRepo = activityRepo;
        }

        public Activity Add(Activity Activity)
        {
            return _activityRepo.Add(Activity);
        }
        public Activity Get(int id)
        {
            var activityId = _activityRepo.Get(id);
            return activityId;
        }
        public Activity Update(Activity updatedActivity)
        {
            var currentActivity = _activityRepo.Update(updatedActivity);
            return currentActivity;
        }
        public void Remove(Activity Activity)
        {
            _activityRepo.Remove(Activity);
        }
        public IEnumerable<Activity> GetAll()
        {
            return _activityRepo.GetAll();
        }
    }
}
