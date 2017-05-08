using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WorkoutTracker.Api.Controllers.Abstract;
using WorkoutTracker.Core.Implementation.Domain;
using WorkoutTracker.Core.Implementation.Queries.Concrete;
using WorkoutTracker.Core.Implementation.QueryHandlers.Abstract;

namespace WorkoutTracker.Api.Controllers.Concrete
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
