using System.Collections.Generic;
using System.Web.Http;
using WorkoutTracker.Models;

namespace WorkoutTracker.Api.Controllers
{
    public class WorkoutTemplateController : ApiController
    {
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
    }
}
