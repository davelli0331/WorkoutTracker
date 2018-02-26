using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Web.Controllers.Abstract;

namespace WorkoutTracker.Web.Controllers.ViewControllers
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
