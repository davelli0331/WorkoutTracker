using System.Collections.Generic;
using System.Linq;
using Moq;
using WorkoutTracker.Core.Implementation.ActionHandlers.Concrete.WorkoutTemplateActionHandlers;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.DbContexts.Abstract;
using WorkoutTracker.Core.Implementation.Domain;
using Xunit;
using System.Linq.Expressions;
using System;

namespace WorkoutTracker.Tests.CommandTests.WorkoutTemplateCommandTests
{
    public class AddWorkoutTemplateCommandTests
    {
        readonly Mock<ICommandDbContext> _dbContext = new Mock<ICommandDbContext>();

        [Fact]
        public void AddWorkoutTemplateCommand_Succeeds()
        {
            var command = new AddWorkoutTemplateActionHandler(_dbContext.Object);
            command.Handle(new AddWorkoutTemplateAction
            {
                Name = "Test",
                Description = "Test Description",
                Exercises = new List<WorkoutTemplateExercise>
                {
                    new WorkoutTemplateExercise
                    {
                        TemplateName = "Test",
                        ExerciseId = 1,
                        ExerciseOrder = 2,
                        PrescribedNumberOfReps = 10,
                        PrescribedNumberOfSets = 3
                    }
                }
            });

            _dbContext.Verify(db => db.Create(It.Is<WorkoutTemplate>(w =>
                w.TemplateName == "Test" &&
                w.TemplateDescription == "Test Description")), Times.Once());
            _dbContext.Verify(db => db.DeleteWhere(It.IsAny<Expression<Func<WorkoutTemplateExercise, bool>>>()), Times.Once());
            _dbContext.Verify(db => db.CreateRange(It.Is<IEnumerable<WorkoutTemplateExercise>>(wte => wte.Count() == 1)), Times.Once());
            _dbContext.Verify(db => db.SaveChanges(), Times.Once());
        }
    }
}