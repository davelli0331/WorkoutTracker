using System.Collections.Generic;
using MediatR;
using WorkoutTracker.Core.Domain;

namespace WorkoutTracker.Core.Queries.Requests
{
    public class ExerciseQueryRequest : IRequest<IEnumerable<Exercise>>
    {
    }
}
