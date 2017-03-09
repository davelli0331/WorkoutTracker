using System.Collections.Generic;

namespace WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions
{
    public class AddWorkoutTemplateAction
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<int> ExerciseIds { get; set; } = new List<int>();
    }
}
