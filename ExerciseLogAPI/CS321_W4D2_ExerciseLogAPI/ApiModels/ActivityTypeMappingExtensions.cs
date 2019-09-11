using CS321_W4D2_ExerciseLogAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CS321_W4D2_ExerciseLogAPI.ApiModels
{
    public static class ActivityTypeMappingExtenstions
    {

        public static ActivityTypeModel ToApiModel(this ActivityType ActivityType)
        {
            return new ActivityTypeModel
            {
                Id = ActivityType.Id,
                Name = ActivityType.Name,
                RecordType = ActivityType.RecordType
                // TODO: fill in property mappings
            };
        }

        public static ActivityType ToDomainModel(this ActivityTypeModel ActivityTypeModel)
        {
            return new ActivityType
            {
                Id = ActivityTypeModel.Id,
                Name = ActivityTypeModel.Name,
                RecordType = ActivityTypeModel.RecordType
                // TODO: fill in property mappings
            };
        }

        public static IEnumerable<ActivityTypeModel> ToApiModels(this IEnumerable<ActivityType> ActivityTypes)
        {
            if (ActivityTypes == null) return null;
            return ActivityTypes.Select(a => a.ToApiModel()).ToList();
        }

        public static IEnumerable<ActivityType> ToDomainModels(this IEnumerable<ActivityTypeModel> ActivityTypeModels)
        {
            if (ActivityTypeModels == null) return null;
            return ActivityTypeModels.Select(a => a.ToDomainModel()).ToList();
        }
    }
}
