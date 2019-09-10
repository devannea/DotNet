using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W4D2_ExerciseLogAPI.Core.Models
{
    public enum RecordType
    {
        DurationOnly, // only record duration
        DurationAndDistance // record duration and distance
    }

    public class ActivityType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RecordType RecordType { get; set; }
    }
}
