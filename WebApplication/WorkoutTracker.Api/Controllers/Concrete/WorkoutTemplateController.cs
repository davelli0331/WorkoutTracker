using System.Collections.Generic;
using System.Web.Http;
using WorkoutTracker.Api.Controllers.Abstract;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.CommandDispatchers.Abstract;
using WorkoutTracker.Core.Implementation.Domain;
using WorkoutTracker.Core.Implementation.Queries;
using WorkoutTracker.Core.Implementation.QueryHandlers.Abstract;

namespace WorkoutTracker.Api.Controllers.Concrete
{
    public class WorkoutTemplateController : BaseController
    {
        private readonly IWorkoutTemplateCommandDispatcher _commandDispatcher;
        private readonly IQueryHandler<WorkoutTemplateQuery, IEnumerable<WorkoutTemplate>> _queryHandler;

        public WorkoutTemplateController() { }

        public WorkoutTemplateController(
            IWorkoutTemplateCommandDispatcher commandDispatcher,
            IQueryHandler<WorkoutTemplateQuery, IEnumerable<WorkoutTemplate>> queryHandler)
        {
            _commandDispatcher = commandDispatcher;
            _queryHandler = queryHandler;
        }

        public IHttpActionResult Get(string name = null, string description = null)
        {
            return Ok(_queryHandler.Handle(new WorkoutTemplateQuery
            {
                WorkoutTemplateName = name
            }));
        }

        public IHttpActionResult Post(AddWorkoutTemplateAction action)
        {
            return Result(_commandDispatcher.Dispatch(action));
        }
    }
}
