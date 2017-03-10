using WorkoutTracker.Core.Implementation.ActionHandlers.Concrete.WorkoutTemplateCommands;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.CommandDispatchers.Concrete;
using WorkoutTracker.Core.Implementation.DbContexts.Concrete;
using Xunit;

namespace WorkoutTracker.Tests.ControllerTests.Integration
{
    public class WorkoutTemplateControllerTests
    {
        [Fact]
        public void Post_Succeeds()
        {
            var dbContext = new CommandDbContext();
            var actionHandler = new AddWorkoutTemplateActionHandler(dbContext);
            var dispatcher = new WorkoutTemplateCommandDispatcher(actionHandler);

            var result = dispatcher.Dispatch(new AddWorkoutTemplateAction
            {
                Name = "Test",
                Description = "Test Description"
            });

            Assert.True(result.Succeeded);
            Assert.Null(result.CaughtException);
        }
    }
}