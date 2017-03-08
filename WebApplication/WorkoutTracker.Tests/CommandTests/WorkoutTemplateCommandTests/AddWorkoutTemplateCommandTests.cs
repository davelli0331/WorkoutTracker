using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using WorkoutTracker.Contracts.DbContexts;
using Xunit;

namespace WorkoutTracker.Tests.CommandTests.WorkoutTemplateCommandTests
{
    public class AddWorkoutTemplateCommandTests
    {
        [Fact]
        public void AddWorkoutTemplateCommand_Succeeds()
        {
            var dbContext = new Mock<ICommandDbContext>();
            //var command = new AddWorkoutTemplateCommand
        }
    }
}
