using System.Collections.Generic;
using System.Linq;
using MediatR;
using WorkoutTracker.Core.DbContexts.Abstract;
using WorkoutTracker.Core.Domain;
using WorkoutTracker.Core.Queries.Requests;

namespace WorkoutTracker.Core.Queries.Handlers
{
    public class ExerciseQueryHandler : RequestHandler<ExerciseQueryRequest, IEnumerable<Exercise>>
    {
        private readonly IQueryDbContext _dbContext;

        public ExerciseQueryHandler(IQueryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected override IEnumerable<Exercise> HandleCore(ExerciseQueryRequest query)
        {
            return _dbContext.Query<Exercise>()
                .OrderBy(e => e.ExerciseName)
                .ToList();
        }
    }
}
