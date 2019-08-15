using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseLogAPI.Core.Services
{
    class ActivityTypeService
    {
        private IActivityTypeRepository _activityTypeRepo;

        public ActivityTypeService(IActivityTypeRepository activityTypeRepo)
        {
            _activityTypeRepo = activityTypeRepo;
        }
    }
}
