using System.Threading;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Core.Commands.Requests;
using WorkoutTracker.Core.Queries.Requests;
using WorkoutTracker.Web.Controllers.Abstract;

namespace WorkoutTracker.Web.Controllers.ApiControllers
{
    [Route("api/Exercise")]
    public class ExerciseApiController : BaseController
    {
        private readonly IMediator _mediator;

        public ExerciseApiController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return PartialView("~/Views/Partials/Exercise/List.cshtml", _mediator.Send(new ExerciseQueryRequest()).Result);
        }

        [HttpPost]
        public ActionResult Post(AddExerciseCommandRequest request)
        {
            _mediator.Send(request, CancellationToken.None);

            return Ok();
        }
    }
}
