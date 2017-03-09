using Moq;
using WorkoutTracker.CommandsAndQueries.Commands.Concrete.WorkoutTemplateCommands;
using WorkoutTracker.Models;
using WorkoutTracker.Persistence.DbContexts;
using Xunit;

namespace WorkoutTracker.Tests.CommandTests
{
    public class AddWorkoutTemplateTests
    {
        private Mock<ICommandDbContext> _mockContext = new Mock<ICommandDbContext>();

        [Fact]
        public void Succeeds()
        {
            var command = new AddWorkoutTemplateCommand(_mockContext.Object, new WorkoutTemplate
            {
                TemplateName = "Test Name",
                TemplateDescription = "Test Description"
            });
            command.Execute();

            _mockContext.Verify(db => db.Create(It.Is<WorkoutTemplate>(w =>
                w.TemplateName == "Test Name" &&
                w.TemplateDescription == "Test Description"
            )), Times.Once());
        }
    }
}
