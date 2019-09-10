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
                // TODO: fill in property mappings

            };
        }

        public static User ToDomainModel(this UserModel UserModel)
        {
            return new User
            {
                Id = UserModel.Id,
                // TODO: fill in property mappings
            };
        }

        public static IEnumerable<UserModel> ToApiModels(this IEnumerable<User> Users)
        {
            return Users.Select(a => a.ToApiModel());
        }

        public static IEnumerable<User> ToDomainModels(this IEnumerable<UserModel> UserModels)
        {
            return UserModels.Select(a => a.ToDomainModel());
        }
    }
}
