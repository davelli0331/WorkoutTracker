using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Results;
using WorkoutTracker.Api.Controllers.Concrete;
using WorkoutTracker.Core.Implementation.ActionDispatchers.Concrete;
using WorkoutTracker.Core.Implementation.ActionHandlers.Concrete.WorkoutTemplateActionHandlers;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.DbContexts.Concrete;
using WorkoutTracker.Core.Implementation.Domain;
using WorkoutTracker.Core.Implementation.QueryHandlers;
using WorkoutTracker.Core.Implementation.QueryHandlers.Concrete;
using Xunit;

namespace WorkoutTracker.Tests.ControllerTests.Integration
{
    public class WorkoutTemplateControllerTests
    {
        //[Fact]
        public void Post_Succeeds()
        {
            var dbContext = new WorkoutDbContext();
            var actionHandler = new AddWorkoutTemplateActionHandler(dbContext);
            var dispatcher = new WorkoutTemplateActionDispatcher(actionHandler);

            var result = dispatcher.Dispatch(new AddWorkoutTemplateAction
            {
                Name = "Test",
                Description = "Test Description"
            });

            Assert.True(result.Succeeded);
            Assert.Null(result.CaughtException);
        }

        //[Fact]
        public void Get_Succeeds()
        {
            var dbContext = new WorkoutDbContext();
            var handler = new WorkoutTemplateQueryHandler(dbContext);

            var controller = new WorkoutTemplateController(null, handler);
            var result = (OkNegotiatedContentResult<IEnumerable<WorkoutTemplate>>) controller.Get(name: "Test");

            Assert.Equal(1, result.Content.Count());
        }
    }
}