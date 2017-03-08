using Moq;
using WorkoutTracker.Dispatchers.Actions.WorkoutTemplateActions;
using WorkoutTracker.Dispatchers.CommandDispatchers.Concrete;
using WorkoutTracker.Persistence.DbContexts;
using Xunit;

namespace WorkoutTracker.Tests.CommandDispatcherTests
{
    public class WorkoutTemplateDispatcherTests
    {
        private readonly Mock<ICommandDbContext> _dbContext = new Mock<ICommandDbContext>();

        [Fact]
        public void WorkoutTemplateDispatcher_Dispatch_Add_Workout_Template_Succeeds()
        {
            var dispatcher = new WorkoutTemplateCommandDispatcher(_dbContext.Object);
            var result = dispatcher.Dispatch(new AddWorkoutTemplateAction
            {
                Name = "Test",
                Description = "Description"
            });

            Assert.True(result.Succeeded);
            Assert.Null(result.CaughtException);
        }
    }
}
