﻿namespace WorkoutTracker.Core.NetCore.Domain
{
    public class Exercise
    {
        public int ExerciseId { get; set; }
        public string ExerciseName { get; set; }
        public string Instruction { get; set; }
        public string PushPullIndicator { get; set; }
    }
}
