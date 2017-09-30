using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Api.NetCore.Controllers.Abstract;
using WorkoutTracker.Core.NetCore.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.NetCore.Queries.Concrete;
using MediatR;

namespace WorkoutTracker.Api.NetCore.Controllers.Concrete
{
    [Route("api/[controller]")]
    public class WorkoutTemplateController : BaseController
    {
        private readonly IMediator _mediator;

        //public WorkoutTemplateController() { }

        public WorkoutTemplateController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public ActionResult Get(string name = null, string description = null)
        {
            return Ok(_mediator.Send(new WorkoutTemplateQuery
            {
                WorkoutTemplateName = name
            }));
        }

        [HttpPost]
        public ActionResult Post(AddWorkoutTemplateAction action)
        {
            _mediator.Send(action);

            return Ok();
        }
    }
}
