using System.Collections.Generic;
using System.Linq;
using WorkoutTracker.Core.Implementation.DbContexts.Abstract;
using WorkoutTracker.Core.Implementation.Domain;
using WorkoutTracker.Core.Implementation.Queries.Concrete;
using WorkoutTracker.Core.Implementation.QueryHandlers.Abstract;

namespace WorkoutTracker.Core.Implementation.QueryHandlers.Concrete
{
    public class ExerciseQueryHandler : IQueryHandler<ExerciseQuery, IEnumerable<Exercise>>
    {
        private readonly IQueryDbContext _dbContext;

        public ExerciseQueryHandler(IQueryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Exercise> Handle(ExerciseQuery query)
        {
            return _dbContext.Query<Exercise>()
                .OrderBy(e => e.ExerciseName)
                .ToList();
        }
    }
}
