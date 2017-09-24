using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Api.NetCore.Controllers.Abstract;
using WorkoutTracker.Core.NetCore.ActionDispatchers.Abstract;
using WorkoutTracker.Core.NetCore.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.NetCore.Domain;
using WorkoutTracker.Core.NetCore.Queries.Concrete;
using WorkoutTracker.Core.NetCore.QueryHandlers.Abstract;

namespace WorkoutTracker.Api.NetCore.Controllers.Concrete
{
    [Route("api/[controller]")]
    public class WorkoutTemplateController : BaseController
    {
        private readonly IWorkoutTemplateActionDispatcher _actionDispatcher;
        private readonly IQueryHandler<WorkoutTemplateQuery, IEnumerable<WorkoutTemplate>> _queryHandler;

        //public WorkoutTemplateController() { }

        public WorkoutTemplateController(
            IWorkoutTemplateActionDispatcher actionDispatcher,
            IQueryHandler<WorkoutTemplateQuery, IEnumerable<WorkoutTemplate>> queryHandler)
        {
            _actionDispatcher = actionDispatcher;
            _queryHandler = queryHandler;
        }

        [HttpGet]
        public ActionResult Get(string name = null, string description = null)
        {
            return Ok(_queryHandler.Handle(new WorkoutTemplateQuery
            {
                WorkoutTemplateName = name
            }));
        }

        [HttpPost]
        public ActionResult Post(AddWorkoutTemplateAction action)
        {
            return Result(_actionDispatcher.Dispatch(action));
        }
    }
}
