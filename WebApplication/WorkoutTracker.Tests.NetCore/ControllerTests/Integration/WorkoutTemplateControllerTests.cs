using System.Collections.Generic;
using Xunit;

namespace WorkoutTracker.Tests.NetCore.ControllerTests.Integration
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
    }
}