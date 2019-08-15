using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseLogAPI.Core.Services
{
    class ActivityService
    {
        private IActivityRepository _activityRepo;

        public ActivityService(IActivityRepository activityRepo)
        {
            _activityRepo = activityRepo;
        }
    }
}
