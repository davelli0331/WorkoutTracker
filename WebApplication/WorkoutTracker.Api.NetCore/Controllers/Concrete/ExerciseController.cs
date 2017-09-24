using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Api.NetCore.Controllers.Abstract;
using WorkoutTracker.Core.NetCore.Domain;
using WorkoutTracker.Core.NetCore.Queries.Concrete;
using WorkoutTracker.Core.NetCore.QueryHandlers.Abstract;

namespace WorkoutTracker.Api.NetCore.Controllers.Concrete
{
    public class ExerciseController : BaseController
    {
        private IQueryHandler<ExerciseQuery, IEnumerable<Exercise>> _queryHandler;

        public ExerciseController() { }

        public ExerciseController(IQueryHandler<ExerciseQuery, IEnumerable<Exercise>> queryHandler)
        {
            _queryHandler = queryHandler;
        }

        public ActionResult Get()
        {
            return Ok(_queryHandler.Handle(new ExerciseQuery()));
        }
    }
}
