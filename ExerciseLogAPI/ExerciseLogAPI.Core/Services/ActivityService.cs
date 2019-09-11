using CS321_W4D2_ExerciseLogAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public class ActivityService : IActivityService
    {
        private IActivityRepository _activityRepo;
        private IActivityTypeRepository _activityTypeRepo;

        public ActivityService(IActivityRepository activityRepo, IActivityTypeRepository activityTypeRepo)
        {
            _activityRepo = activityRepo;
            _activityTypeRepo = activityTypeRepo;
        }

        public Activity Add(Activity Activity)
        {
            // retrieve the ActivityType so we can check
            var activityType = _activityTypeRepo.Get(Activity.ActivityTypeId);
            // for a DurationAndDistance activity, you must supply a Distance
            if (activityType.RecordType == RecordType.DurationAndDistance
                && Activity.Distance <= 0)
            {
                throw new ApplicationException("You must supply a Distance for this activity.");
            }
            // for either type, you must supply a Duration
            if (Activity.Duration <= 0)
            {
                throw new ApplicationException("You must supply a Duration for this activity.");
            }
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
