using MediatR;
using System.Collections.Generic;
using WorkoutTracker.Core.NetCore.Domain;

namespace WorkoutTracker.Core.NetCore.Actions.WorkoutTemplateActions
{
    public class AddWorkoutTemplateAction : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<WorkoutTemplateExercise> Exercises { get; set; }
    }
}
