using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Api.NetCore.Controllers.Abstract;
using WorkoutTracker.Core.NetCore.Queries.Concrete;
using MediatR;

namespace WorkoutTracker.Api.NetCore.Controllers.Concrete
{
    [Route("Exercise")]
    public class ExerciseController : BaseController
    {
        private readonly IMediator _mediator;

        public ExerciseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public ActionResult Get()
        {
            return Ok(_mediator.Send(new ExerciseQuery()));
        }

        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
