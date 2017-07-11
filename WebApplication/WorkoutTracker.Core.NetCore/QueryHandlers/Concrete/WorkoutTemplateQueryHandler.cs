using System.Collections.Generic;
using System.Linq;
using WorkoutTracker.Core.NetCore.DbContexts.Abstract;
using WorkoutTracker.Core.NetCore.Domain;
using WorkoutTracker.Core.NetCore.Queries.Concrete;
using WorkoutTracker.Core.NetCore.QueryHandlers.Abstract;

namespace WorkoutTracker.Core.NetCore.QueryHandlers.Concrete
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
                .Where(wt => string.IsNullOrEmpty(query.WorkoutTemplateName) || wt.TemplateName == query.WorkoutTemplateName)
                .ToList();
        }
    }
}
