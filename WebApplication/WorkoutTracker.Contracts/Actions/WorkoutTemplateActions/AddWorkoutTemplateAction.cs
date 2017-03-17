using System.Collections.Generic;
using WorkoutTracker.Core.Implementation.Domain;

namespace WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions
{
    public class AddWorkoutTemplateAction
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<WorkoutTemplateExercise> Exercises { get; set; }
    }
}
