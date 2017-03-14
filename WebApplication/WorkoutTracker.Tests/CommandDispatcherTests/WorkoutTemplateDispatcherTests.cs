using Moq;
using System.Collections.Generic;
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

        [Fact]
        public void AddExercisesToWorkoutTemplateAction_Succeeds()
        {
            _addHandler
                .Setup(f => f.Buid(It.IsAny<AddExercisesToWorkoutTemplateAction>()))
                .Returns(new StubSuccessActionHandler<AddExercisesToWorkoutTemplateAction>());

            var dispatcher = new WorkoutTemplateActionDispatcher(_addHandler.Object);
            var result = dispatcher.Dispatch(new AddExercisesToWorkoutTemplateAction
            {
                Name = "Test",
                ExerciseIds = new List<int> { 1, 2, 3 }
            });

            Assert.True(result.Succeeded);
            Assert.Null(result.CaughtException);
        }
    }
}