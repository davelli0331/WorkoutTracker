using System.Collections.Generic;
using System.Web.Http;
using WorkoutTracker.Api.Controllers.Abstract;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.CommandDispatchers.Abstract;
using WorkoutTracker.Core.Implementation.Domain;

namespace WorkoutTracker.Api.Controllers.Concrete
{
    public class WorkoutTemplateController : BaseController
    {
        private readonly IWorkoutTemplateCommandDispatcher _commandDispatcher;

        public WorkoutTemplateController() { }
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
                    WorkoutTemplateExercises = new List<WorkoutTemplateExercise>
                    {
                        new WorkoutTemplateExercise
                        {
                            ExerciseId = 1,
                            TemplateName = "Push Day"
                        }
                    }
                }
            });
        }

        public IHttpActionResult Post(AddWorkoutTemplateAction action)
        {
            return Result(_commandDispatcher.Dispatch(action));
        }
    }
}
