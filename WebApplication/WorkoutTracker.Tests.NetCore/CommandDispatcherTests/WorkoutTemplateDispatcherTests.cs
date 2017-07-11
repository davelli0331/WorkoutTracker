using System;
using WorkoutTracker.Core.NetCore.ActionDispatchers.Concrete;
using WorkoutTracker.Core.NetCore.ActionHandlerFactory.Abstract;
using WorkoutTracker.Core.NetCore.Actions.WorkoutTemplateActions;
using WorkoutTracker.Tests.NetCore.Stubs;
using Xunit;


namespace WorkoutTracker.Tests.NetCore.CommandDispatcherTests
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