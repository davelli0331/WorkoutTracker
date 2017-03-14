using Moq;
using System.Collections.Generic;
using WorkoutTracker.Core.Implementation.ActionDispatchers.Concrete;
using WorkoutTracker.Core.Implementation.ActionHandlers.Abstract;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using Xunit;

namespace WorkoutTracker.Tests.CommandDispatcherTests
{
    public class WorkoutTemplateDispatcherTests
    {
        private readonly Mock<IActionHandler<AddWorkoutTemplateAction>> _addHandler = new Mock<IActionHandler<AddWorkoutTemplateAction>>();
        private readonly Mock<IActionHandler<AddExercisesToWorkoutTemplateAction>> _addExercisesHandler = new Mock<IActionHandler<AddExercisesToWorkoutTemplateAction>>();

        [Fact]
        public void AddWorkoutTemplateAction_Succeeds()
        {
            var dispatcher = new WorkoutTemplateActionDispatcher(_addHandler.Object, null);
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
            var dispatcher = new WorkoutTemplateActionDispatcher(_addHandler.Object, _addExercisesHandler.Object);
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