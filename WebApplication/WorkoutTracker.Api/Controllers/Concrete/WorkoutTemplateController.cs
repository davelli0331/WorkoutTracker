using System.Collections.Generic;
using System.Web.Http;
using WorkoutTracker.Api.ViewModels.WorkoutTemplate;
using WorkoutTracker.Core.Api;
using WorkoutTracker.Models;

namespace WorkoutTracker.Api.Controllers
{
    public class WorkoutTemplateController : ApiController
    {
        private readonly IWorkoutTemplateCommandFactory _commandFactory;

        public WorkoutTemplateController(IWorkoutTemplateCommandFactory commandFactory)
        {
            _commandFactory = commandFactory;
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
            return Ok();
        }
    }
}
