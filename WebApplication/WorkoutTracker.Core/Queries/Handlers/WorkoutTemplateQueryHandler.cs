using System.Collections.Generic;
using System.Linq;
using MediatR;
using WorkoutTracker.Core.DbContexts.Abstract;
using WorkoutTracker.Core.Domain;
using WorkoutTracker.Core.Queries.Requests;

namespace WorkoutTracker.Core.Queries.Handlers
{
    public class WorkoutTemplateQueryHandler : RequestHandler<WorkoutTemplateQueryRequest, IEnumerable<WorkoutTemplate>>
    {
        private readonly IQueryDbContext _dbContext;
        public WorkoutTemplateQueryHandler(IQueryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected override IEnumerable<WorkoutTemplate> HandleCore(WorkoutTemplateQueryRequest query)
        {
            return _dbContext.Query<WorkoutTemplate>()
                .Where(wt => string.IsNullOrEmpty(query.WorkoutTemplateName) || wt.TemplateName == query.WorkoutTemplateName)
                .ToList();
        }
    }
}
