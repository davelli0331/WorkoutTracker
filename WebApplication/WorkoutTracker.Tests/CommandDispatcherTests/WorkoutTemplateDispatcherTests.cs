using Moq;
using WorkoutTracker.Core.Implementation.ActionHandlers.Abstract;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.CommandDispatchers.Concrete;
using Xunit;

namespace WorkoutTracker.Tests.CommandDispatcherTests
{
    public class WorkoutTemplateDispatcherTests
    {
        private readonly Mock<IActionHandler<AddWorkoutTemplateAction>> _addHandler = new Mock<IActionHandler<AddWorkoutTemplateAction>>();

        [Fact]
        public void WorkoutTemplateDispatcher_Dispatch_Add_Workout_Template_Succeeds()
        {
            var dispatcher = new WorkoutTemplateCommandDispatcher(_addHandler.Object);
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