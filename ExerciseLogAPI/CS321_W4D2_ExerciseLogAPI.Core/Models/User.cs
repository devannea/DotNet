using System;
using System.Collections.Generic;

namespace CS321_W4D2_ExerciseLogAPI.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Activity> Activities { get; set; }
    }
}
