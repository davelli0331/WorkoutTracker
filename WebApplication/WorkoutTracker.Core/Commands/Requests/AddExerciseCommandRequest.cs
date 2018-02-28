using MediatR;

namespace WorkoutTracker.Core.Commands.Requests
{
    public class AddExerciseCommandRequest : IRequest
    {
        public string ExerciseName { get; set; }
        public string Instruction { get; set; }
        public string PushPullIndicator { get; set; }
    }
}
