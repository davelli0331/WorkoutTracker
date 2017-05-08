using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WorkoutTracker.Api.Controllers.Abstract;
using WorkoutTracker.Core.Implementation.ActionDispatchers.Abstract;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.Domain;
using WorkoutTracker.Core.Implementation.Queries.Concrete;
using WorkoutTracker.Core.Implementation.QueryHandlers.Abstract;

namespace WorkoutTracker.Api.Controllers.Concrete
{
    public class WorkoutTemplateController : BaseController
    {
        private readonly IWorkoutTemplateActionDispatcher _actionDispatcher;
        private readonly IQueryHandler<WorkoutTemplateQuery, IEnumerable<WorkoutTemplate>> _queryHandler;

        public WorkoutTemplateController() { }

        public WorkoutTemplateController(
            IWorkoutTemplateActionDispatcher actionDispatcher,
            IQueryHandler<WorkoutTemplateQuery, IEnumerable<WorkoutTemplate>> queryHandler)
        {
            _actionDispatcher = actionDispatcher;
            _queryHandler = queryHandler;
        }

        public ActionResult Get(string name = null, string description = null)
        {
            return Ok(_queryHandler.Handle(new WorkoutTemplateQuery
            {
                WorkoutTemplateName = name
            }));
        }

        public ActionResult Post(AddWorkoutTemplateAction action)
        {
            return Result(_actionDispatcher.Dispatch(action));
        }
    }
}
