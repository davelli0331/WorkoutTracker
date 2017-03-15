using System;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WorkoutTracker.Core.Implementation.ActionHandlers.Concrete.WorkoutTemplateActionHandlers;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.DbContexts.Abstract;
using WorkoutTracker.Core.Implementation.Domain;
using Xunit;

namespace WorkoutTracker.Tests.CommandTests.WorkoutTemplateCommandTests
{
    public class AddExercisesToWorkoutTemplateActionHandlerTests
    {
        private readonly Mock<ICommandDbContext> _dbContext = new Mock<ICommandDbContext>();

        [Fact]
        public void Succeeds()
        {
            var handler = new AddExercisesToWorkoutTemplateActionHandler(_dbContext.Object);
            handler.Handle(new AddExercisesToWorkoutTemplateAction
            {
                Name = "Test 1",
                ExerciseIds = new List<int> { 1, 2, 3 }
            });

            _dbContext.Verify(db => db.DeleteWhere(It.IsAny<Expression<Func<WorkoutTemplateExercise, bool>>>()));
            _dbContext.Verify(db => db.CreateRange(It.Is<IEnumerable<WorkoutTemplateExercise>>(wte => wte.Count() == 3)), Times.Once());
        }
    }
}
