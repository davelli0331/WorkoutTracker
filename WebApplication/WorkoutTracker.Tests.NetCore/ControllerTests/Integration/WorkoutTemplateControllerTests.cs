using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Api.NetCore.Controllers.Concrete;
using WorkoutTracker.Core.NetCore.DbContexts.Concrete;
using WorkoutTracker.Core.NetCore.Domain;
using WorkoutTracker.Core.NetCore.QueryHandlers.Concrete;
using Xunit;
using Moq;
using MediatR;

namespace WorkoutTracker.Tests.NetCore.ControllerTests.Integration
{
    public class WorkoutTemplateControllerTests
    {
        private const string _connectionString =
            @"Server=DELLXPS13\SQL2016EXPRESS;Database=WorkoutTracker;Trusted_Connection=True;";
        private readonly Mock<IMediator> _mockMediator = new Mock<IMediator>();

        [Fact]
        public void Get_Succeeds()
        {
            var dbContext = new WorkoutDbContext(_connectionString);
            var handler = new WorkoutTemplateQueryHandler(dbContext);

            var controller = new WorkoutTemplateController(_mockMediator.Object);
            var result = (OkObjectResult)controller.Get(name: "Test");

            Assert.Equal(1, ((IEnumerable<WorkoutTemplate>)result.Value).Count());
        }
    }
}