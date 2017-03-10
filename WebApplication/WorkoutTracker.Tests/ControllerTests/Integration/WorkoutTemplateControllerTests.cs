using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutTracker.Core.Implementation.ActionHandlers.Concrete.WorkoutTemplateCommands;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.CommandDispatchers.Concrete;
using WorkoutTracker.Persistence.DbContexts.Concrete;
using Xunit;

namespace WorkoutTracker.Tests.ControllerTests.Integration
{
    public class WorkoutTemplateControllerTests
    {
        [Fact]
        public void Post_Succeeds()
        {
            var dbContext = new CommandDbContext();
            var actionHandler = new AddWorkoutTemplateActionHandler(dbContext);
            var dispatcher = new WorkoutTemplateCommandDispatcher(actionHandler);

            //dispatcher.Dispatch(new AddWorkoutTemplateAction
            //{
            //    Name
            //});
        }
    }
}
