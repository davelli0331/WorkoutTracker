using System.Collections.Generic;
using System.Linq;
using Moq;
using WorkoutTracker.CommandsAndQueries.Commands.Concrete.WorkoutTemplateCommands;
using WorkoutTracker.Models;
using WorkoutTracker.Persistence.DbContexts;
using Xunit;

namespace WorkoutTracker.Tests.CommandTests.WorkoutTemplateCommandTests
{
    public class AddWorkoutTemplateCommandTests
    {
        readonly Mock<ICommandDbContext> _dbContext = new Mock<ICommandDbContext>();

        [Fact]
        public void AddWorkoutTemplateCommand_Succeeds()
        {
            var command = new AddWorkoutTemplateCommand(_dbContext.Object, new WorkoutTemplate
            {
                TemplateName = "Test",
                TemplateDescription = "Test Description"
            });
            command.Execute();

            _dbContext.Verify(db => db.Create(It.Is<WorkoutTemplate>(w =>
                w.TemplateName == "Test" &&
                w.TemplateDescription == "Test Description")), Times.Once());
        }

        [Fact]
        public void AddWorkoutTemplateCommand_With_Exercises()
        {
            var command = new AddWorkoutTemplateCommand(_dbContext.Object, new WorkoutTemplate
            {
                TemplateName = "Test",
                TemplateDescription = "Test Description",
                Exercises = new List<Exercise>
                {
                    new Exercise
                    {
                        ExerciseId = 1
                    },
                    new Exercise
                    {
                        ExerciseId = 2
                    }
                }
            });
            command.Execute();

            _dbContext.Verify(db => db.Create(It.Is<WorkoutTemplate>(w =>
                w.TemplateName == "Test" &&
                w.TemplateDescription == "Test Description" &&
                w.Exercises.Count(e => e.ExerciseId == 1) == 1 &&
                w.Exercises.Count(e => e.ExerciseId == 2) == 1)), Times.Once());
        }
    }
}
