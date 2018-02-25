using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Api.NetCore.Controllers.Abstract;
using WorkoutTracker.Core.NetCore.Queries.Concrete;

namespace WorkoutTracker.Api.NetCore.Controllers.ApiControllers
{
    [Route("api/Exercise")]
    public class ExerciseApiController : BaseController
    {
        private readonly IMediator _mediator;

        public ExerciseApiController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Get()
        {
            return PartialView("~/Views/Partials/Exercise/List.cshtml", _mediator.Send(new ExerciseQuery()).Result);
        }
    }
}
