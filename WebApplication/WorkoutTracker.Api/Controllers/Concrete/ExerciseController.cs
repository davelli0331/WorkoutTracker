using System.Collections.Generic;
using System.Web.Http;
using WorkoutTracker.Api.Controllers.Abstract;
using WorkoutTracker.Core.Implementation.Domain;

namespace WorkoutTracker.Api.Controllers.Concrete
{
    public class ExerciseController : BaseController
    {
        public IHttpActionResult Get()
        {
            return Ok(new List<Exercise>
            {
                new Exercise
                {
                    ExerciseName = "Bench Press",
                    ExerciseId = 1 ,
                    Instruction = "Do a bench press",
                    PushPullIndicator = "Push"
                },
                new Exercise
                {
                    ExerciseName = "Triceps Pullover",
                    ExerciseId = 2,
                    Instruction = "Do a triceps pullover",
                    PushPullIndicator = "Pull"
                }
            });
        }
    }
}
