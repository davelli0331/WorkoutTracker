using System.Threading;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using WorkoutTracker.Core.Commands.Requests;
using WorkoutTracker.Web.Controllers.Concrete;
using Xunit;

namespace WorkoutTracker.Tests.ControllerTests.Unit
{
    public class WorkoutTemplateControllerTests
    {
        private readonly Mock<IMediator> _mockMediator = new Mock<IMediator>();

        [Fact]
        public void Post_Succeeds()
        {
            var controller = new WorkoutTemplateController(_mockMediator.Object);
            var response = controller.Post(new AddWorkoutTemplateRequest
            {
                Name = "Test1",
                Description = "TestDescription"
            });

            Assert.IsType<OkResult>(response);

            _mockMediator
                .Verify(d => d.Send(It.Is<AddWorkoutTemplateRequest>(a =>
                    a.Name == "Test1" &&
                    a.Description == "TestDescription"
                    ), default(CancellationToken)), Times.Once());
        }

        [Fact]
        public void Post_Fails()
        {
            var controller = new WorkoutTemplateController(_mockMediator.Object);
            var response = controller.Post(new AddWorkoutTemplateRequest
            {
                Name = "Test1",
                Description = "TestDescription"
            });

            _mockMediator
                .Verify(d => d.Send(It.Is<AddWorkoutTemplateRequest>(a =>
                    a.Name == "Test1" &&
                    a.Description == "TestDescription"
                    ), default(CancellationToken)), Times.Once());
        }
    }
}