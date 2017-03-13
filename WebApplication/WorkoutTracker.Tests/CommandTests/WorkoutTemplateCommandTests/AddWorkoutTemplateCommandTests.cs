#region

using System.Collections.Generic;
using System.Linq;
using Moq;
using WorkoutTracker.Core.Implementation.ActionHandlers.Concrete.WorkoutTemplateActionHandlers;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.DbContexts.Abstract;
using WorkoutTracker.Core.Implementation.Domain;
using Xunit;

#endregion

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
                Description = "Test Description"
            });

            _dbContext.Verify(db => db.Create(It.Is<WorkoutTemplate>(w =>
                w.TemplateName == "Test" &&
                w.TemplateDescription == "Test Description")), Times.Once());
        }
    }
}