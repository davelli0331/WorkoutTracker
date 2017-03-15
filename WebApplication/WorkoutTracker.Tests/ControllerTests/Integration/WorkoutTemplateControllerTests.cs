using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Results;
using WorkoutTracker.Api.Controllers.Concrete;
using WorkoutTracker.Core.Implementation.ActionDispatchers.Concrete;
using WorkoutTracker.Core.Implementation.ActionHandlerFactory.Concrete;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.DbContexts.Concrete;
using WorkoutTracker.Core.Implementation.Domain;
using WorkoutTracker.Core.Implementation.QueryHandlers.Concrete;
using Xunit;

namespace WorkoutTracker.Tests.ControllerTests.Integration
{
    public class WorkoutTemplateControllerTests
    {
        //[Fact]
        public void Post_Succeeds()
        {
            var dbContext = new WorkoutDbContext();
            var actionHandler = new ActionHandlerFactory(dbContext);
            var dispatcher = new WorkoutTemplateActionDispatcher(actionHandler);

            var result = dispatcher.Dispatch(new AddWorkoutTemplateAction
            {
                Name = "Test",
                Description = "Test Description"
            });

            Assert.True(result.Succeeded);
            Assert.Null(result.CaughtException);
        }

        //[Fact]
        public void Get_Succeeds()
        {
            var dbContext = new WorkoutDbContext();
            var handler = new WorkoutTemplateQueryHandler(dbContext);

            var controller = new WorkoutTemplateController(null, handler);
            var result = (OkNegotiatedContentResult<IEnumerable<WorkoutTemplate>>)controller.Get(name: "Test");

            Assert.Equal(1, result.Content.Count());
        }

        [Fact]
        public void Add_Exercises_Succeeds()
        {
            var dbContext = new WorkoutDbContext();
            var handlerFactory = new ActionHandlerFactory(dbContext);
            var dispatcher = new WorkoutTemplateActionDispatcher(handlerFactory);

            var controller = new WorkoutTemplateController(dispatcher, null);
            var result = (OkResult)controller.Exercises(new AddExercisesToWorkoutTemplateAction
            {
                Name = "Push Day",
                ExerciseIds = new List<int> { 1, 2 }
            });

            Assert.NotNull(result);
        }
    }
}