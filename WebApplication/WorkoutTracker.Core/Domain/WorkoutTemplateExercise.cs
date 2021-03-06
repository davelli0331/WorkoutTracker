﻿namespace WorkoutTracker.Core.NetCore.Domain
{
    public class WorkoutTemplateExercise
    {
        public string TemplateName { get; set; }
        public int ExerciseId { get; set; }
        public int ExerciseOrder { get; set; }
        public int PrescribedNumberOfSets { get; set; }
        public int PrescribedNumberOfReps { get; set; }

        public WorkoutTemplate WorkoutTemplate { get; set; }
        public Exercise Exercise { get; set; }
    }
}
