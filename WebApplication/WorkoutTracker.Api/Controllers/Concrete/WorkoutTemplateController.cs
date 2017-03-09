using System.Collections.Generic;
using System.Web.Http;
using WorkoutTracker.Api.ViewModels.WorkoutTemplate;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.CommandDispatchers.Abstract;
using WorkoutTracker.Models;

namespace WorkoutTracker.Api.Controllers
{
    public class WorkoutTemplateController : ApiController
    {
        private readonly IWorkoutTemplateCommandDispatcher _commandDispatcher;
        public WorkoutTemplateController(IWorkoutTemplateCommandDispatcher commandDispatcher)
        {
            _commandDispatcher = commandDispatcher;
        }

        public IHttpActionResult Get()
        {
            return Ok(new List<WorkoutTemplate>
            {
                new WorkoutTemplate
                {
                    TemplateName = "Push Day",
                    TemplateDescription = "Only push exercises",
                    Exercises = new List<Exercise>
                    {
                        new Exercise
                        {
                            ExerciseId = 1,
                            ExerciseName = "Bench Press",
                            PushPullIndicator = "Push",
                            Instruction = "Do a bench press"
                        }
                    }
                }
            });
        }

        public IHttpActionResult Post(Add viewModel)
        {
            var result = _commandDispatcher.Dispatch(new AddWorkoutTemplateAction());

            if (result.Succeeded)
            {
                return Ok();
            }
            
            return InternalServerError(result.CaughtException);
        }
    }
}
