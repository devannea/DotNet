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
                // TODO: fill in property mappings
                // TODO: the ActivityType property should contain the name of the activity type
                // TODO: the User property should contain the user's name
            };
        }

        public static Activity ToDomainModel(this ActivityModel activityModel)
        {
            return new Activity
            {
                Id = activityModel.Id,
                // TODO: fill in property mappings
                // TODO: leave User and ActivityType null
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
