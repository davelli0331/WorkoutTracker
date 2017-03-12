using System.Collections.Generic;
using System.Linq;
using WorkoutTracker.Core.Implementation.DbContexts.Abstract;
using WorkoutTracker.Core.Implementation.Domain;
using WorkoutTracker.Core.Implementation.Queries;
using WorkoutTracker.Core.Implementation.QueryHandlers.Abstract;

namespace WorkoutTracker.Core.Implementation.QueryHandlers
{
    public class WorkoutTemplateQueryHandler 
        : IQueryHandler<WorkoutTemplateQuery, IEnumerable<WorkoutTemplate>>
    {
        private readonly IQueryDbContext _dbContext;
        public WorkoutTemplateQueryHandler(IQueryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<WorkoutTemplate> Handle(WorkoutTemplateQuery query)
        {
            return _dbContext.Query<WorkoutTemplate>()
                .Where(wt => wt.TemplateName == query.WorkoutTemplateName)
                .ToList();
        }
    }
}
