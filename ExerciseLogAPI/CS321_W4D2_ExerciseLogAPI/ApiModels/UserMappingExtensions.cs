using CS321_W4D2_ExerciseLogAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CS321_W4D2_ExerciseLogAPI.ApiModels
{
    public static class UserMappingExtenstions
    {

        public static UserModel ToApiModel(this User User)
        {
            return new UserModel
            {
                Id = User.Id,
                Name = User.Name,
                //Activities = User.Activities.ToApiModels()
                // TODO: fill in property mappings

            };
        }

        public static User ToDomainModel(this UserModel UserModel)
        {
            return new User
            {
                Id = UserModel.Id,
                Name = UserModel.Name,
                //Activities = UserModel.Activities.ToDomainModels()
                // TODO: fill in property mappings
            };
        }

        public static IEnumerable<UserModel> ToApiModels(this IEnumerable<User> Users)
        {
            if (Users == null) return null;
            return Users.Select(u => u.ToApiModel()).ToList();
        }

        public static IEnumerable<User> ToDomainModels(this IEnumerable<UserModel> UserModels)
        {
            if (UserModels == null) return null;
            return UserModels.Select(u => u.ToDomainModel()).ToList();
        }
    }
}
