using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutTracker.Core.Implementation.ActionHandlers.Concrete.WorkoutTemplateActionHandlers;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.DbContexts.Abstract;
using WorkoutTracker.Core.Implementation.Domain;
using Xunit;

namespace WorkoutTracker.Tests.CommandTests.WorkoutTemplateCommandTests
{
    public class AddExercisesToWorkoutTemplateActionHandlerTests
    {
        private Mock<ICommandDbContext> _dbContext = new Mock<ICommandDbContext>();

        [Fact]
        public void Succeeds()
        {
            var handler = new AddExercisesToWorkoutTemplateActionHandler(_dbContext.Object);
            handler.Handle(new AddExercisesToWorkoutTemplateAction
            {
                Name = "Test 1",
                ExerciseIds = new List<int> { 1,2,3 }
            });

            _dbContext.Verify(db => db.DeleteWhere<WorkoutTemplateExercise>(wte => wte.TemplateName == "Test 1"), Times.Once());
            _dbContext.Verify(db => db.CreateRange(It.Is<IEnumerable<WorkoutTemplateExercise>>(wte => wte.Count() == 3)), Times.Once());
        }
    }
}
