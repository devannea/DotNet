using ExerciseLogAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CS321_W4D2_ExerciseLogAPI.ApiModels
{
    public static class ActivityMappingExtenstions
    {

        public static ActivityModel ToApiModel(this Activity activity)
        {
            return new ActivityModel
            {
                Id = activity.Id,
                Date = activity.Date,
                Duration = activity.Duration,
                Distance = activity.Distance,
                ActivityTypeId = activity.ActivityType.Id,
                ActivityType = activity.ActivityType,
                UserId = activity.User.Id,
                User = activity.User,
                Notes = activity.Notes
            };
        }

        public static Activity ToDomainModel(this ActivityModel activityModel)
        {
            return new Activity
            {
                Id = activityModel.Id,
                Date = activityModel.Date,
                Duration = activityModel.Duration,
                Distance = activityModel.Distance,
                ActivityTypeId = activityModel.ActivityTypeId,
                ActivityType = activityModel.ActivityType
            };
        }

        public static IEnumerable<ActivityModel> ToApiModels(this IEnumerable<Activity> activities)
        {
            return activities.Select(a => a.ToApiModel());
        }

        public static IEnumerable<Activity> ToDomainModels(this IEnumerable<ActivityModel> activityModels)
        {
            return activityModels.Select(a => a.ToDomainModel());
        }
    }
}
