using System.Collections.Generic;
using System.Web.Http;
using WorkoutTracker.Models;

namespace WorkoutTracker.Api.Controllers
{
    public class ExerciseController : ApiController
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
