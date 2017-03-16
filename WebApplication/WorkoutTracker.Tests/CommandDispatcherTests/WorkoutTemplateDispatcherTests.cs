using Moq;
using WorkoutTracker.Core.Implementation.ActionDispatchers.Concrete;
using WorkoutTracker.Core.Implementation.ActionHandlerFactory.Abstract;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Tests.Stubs;
using Xunit;

namespace WorkoutTracker.Tests.CommandDispatcherTests
{
    public class WorkoutTemplateDispatcherTests
    {
        private readonly Mock<IActionHandlerFactory> _addHandler = new Mock<IActionHandlerFactory>();

        [Fact]
        public void AddWorkoutTemplateAction_Succeeds()
        {
            _addHandler
                .Setup(f => f.Buid(It.IsAny<AddWorkoutTemplateAction>()))
                .Returns(new StubSuccessActionHandler<AddWorkoutTemplateAction>());

            var dispatcher = new WorkoutTemplateActionDispatcher(_addHandler.Object);
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