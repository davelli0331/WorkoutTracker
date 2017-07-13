using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Api.NetCore.Controllers.Concrete;
using WorkoutTracker.Core.NetCore.ActionDispatchers.Concrete;
using WorkoutTracker.Core.NetCore.ActionHandlerFactory.Concrete;
using WorkoutTracker.Core.NetCore.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.NetCore.DbContexts.Concrete;
using WorkoutTracker.Core.NetCore.Domain;
using WorkoutTracker.Core.NetCore.QueryHandlers.Concrete;
using Xunit;

namespace WorkoutTracker.Tests.NetCore.ControllerTests.Integration
{
    public class WorkoutTemplateControllerTests
    {
        private const string _connectionString =
            @"Server=DELLXPS13\SQL2016EXPRESS;Database=WorkoutTracker;Trusted_Connection=True;";

        [Fact]
        public void Post_Succeeds()
        {
            var dbContext = new WorkoutDbContext(_connectionString);
            var actionHandler = new ActionHandlerFactory(dbContext);
            var dispatcher = new WorkoutTemplateActionDispatcher(actionHandler);

            var result = dispatcher.Dispatch(new AddWorkoutTemplateAction
            {
                Name = "Test",
                Description = "Test Description"

            });

            Assert.True(result.Succeeded);
            Assert.Null(result.CaughtException);
        }

        [Fact]
        public void Get_Succeeds()
        {
            var dbContext = new WorkoutDbContext(_connectionString);
            var handler = new WorkoutTemplateQueryHandler(dbContext);

            var controller = new WorkoutTemplateController(null, handler);
            var result = (OkObjectResult)controller.Get(name: "Test");

            Assert.Equal(1, ((IEnumerable<WorkoutTemplate>)result.Value).Count());
        }
    }
}