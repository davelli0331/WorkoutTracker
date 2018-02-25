using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Api.NetCore.Controllers.Abstract;

namespace WorkoutTracker.Api.NetCore.Controllers.ViewControllers
{
    [Route("Exercise")]
    public class ExerciseController : BaseController
    {
        private readonly IMediator _mediator;

        public ExerciseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
