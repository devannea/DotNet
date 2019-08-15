using System;
using System.Collections.Generic;
using System.Text;
using ExerciseLogAPI.Core.Models;


namespace ExerciseLogAPI.Core.Services
{
    interface IActivityTypeRepository
    {
        // Create
        ActivityType Add(ActivityType todo);
        // Read
        ActivityType Get(int id);
        // Update
        ActivityType Update(ActivityType todo);
        // Delete
        void Remove(ActivityType todo);
        // List
        IEnumerable<ActivityType> GetAll();
    }
}
