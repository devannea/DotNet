using System;
using System.Collections.Generic;

namespace CS321_W4D2_ExerciseLogAPI.ApiModels
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<UserModel> Activities { get; set; }
    }
}
