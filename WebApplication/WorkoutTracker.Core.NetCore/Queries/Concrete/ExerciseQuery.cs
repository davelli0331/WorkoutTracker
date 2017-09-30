using MediatR;
using System.Collections.Generic;
using WorkoutTracker.Core.NetCore.Domain;

namespace WorkoutTracker.Core.NetCore.Queries.Concrete
{
    public class ExerciseQuery : IRequest<IEnumerable<Exercise>>
    {
    }
}
