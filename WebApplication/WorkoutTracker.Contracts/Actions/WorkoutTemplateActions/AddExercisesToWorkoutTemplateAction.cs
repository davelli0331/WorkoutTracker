using System.Collections.Generic;

namespace WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions
{
    public class AddExercisesToWorkoutTemplateAction
    {
        public string Name { get; set; }
        public IEnumerable<int> ExerciseIds { get; set; }
    }
}
