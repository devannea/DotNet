using CS321_W4D2_ExerciseLogAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    class ActivityTypeService : IActivityTypeService
    {
        private IActivityTypeRepository _activityTypeRepo;

        public ActivityTypeService(IActivityTypeRepository activityTypeRepo)
        {
            _activityTypeRepo = activityTypeRepo;
        }

        public ActivityType Add(ActivityType ActivityType)
        {
            return _activityTypeRepo.Add(ActivityType);
        }
        public ActivityType Get(int id)
        {
            var activityTypeId = _activityTypeRepo.Get(id);
            return activityTypeId;
        }
        public ActivityType Update(ActivityType updatedActivityType)
        {
            var currentActivityType = _activityTypeRepo.Update(updatedActivityType);
            return currentActivityType;
        }
        public void Remove(ActivityType ActivityType)
        {
            _activityTypeRepo.Remove(ActivityType);
        }
        public IEnumerable<ActivityType> GetAll()
        {
            return _activityTypeRepo.GetAll();
        }
    }
}
