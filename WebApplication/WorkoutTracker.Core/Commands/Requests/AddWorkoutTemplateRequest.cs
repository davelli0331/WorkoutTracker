using System.Collections.Generic;
using MediatR;
using WorkoutTracker.Core.Domain;

namespace WorkoutTracker.Core.Commands.Requests
{
    public class AddWorkoutTemplateRequest : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<WorkoutTemplateExercise> Exercises { get; set; }
    }
}
