﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Core.Commands.Requests;
using WorkoutTracker.Core.Queries.Requests;
using WorkoutTracker.Web.Controllers.Abstract;

namespace WorkoutTracker.Web.Controllers.Concrete
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
            return Ok(_mediator.Send(new WorkoutTemplateQueryRequest
            {
                WorkoutTemplateName = name
            }));
        }

        [HttpPost]
        public ActionResult Post(AddWorkoutTemplateRequest action)
        {
            _mediator.Send(action);

            return Ok();
        }
    }
}
