using System.Collections.Generic;
using WorkoutTracker.Core.Implementation.Domain;
using WorkoutTracker.Core.Implementation.Queries.Abstract;

namespace WorkoutTracker.Core.Implementation.Queries.Concrete
{
    public class ExerciseQuery : IQuery<IEnumerable<Exercise>>
    {
    }
}
