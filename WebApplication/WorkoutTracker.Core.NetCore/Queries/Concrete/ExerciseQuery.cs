using System.Collections.Generic;
using WorkoutTracker.Core.NetCore.Domain;
using WorkoutTracker.Core.NetCore.Queries.Abstract;

namespace WorkoutTracker.Core.NetCore.Queries.Concrete
{
    public class ExerciseQuery : IQuery<IEnumerable<Exercise>>
    {
    }
}
