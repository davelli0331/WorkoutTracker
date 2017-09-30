using WorkoutTracker.Api.NetCore.Controllers.Concrete;
using WorkoutTracker.Core.NetCore.Actions.WorkoutTemplateActions;
using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading;

namespace WorkoutTracker.Tests.NetCore.ControllerTests.Unit
{
    public class WorkoutTemplateControllerTests
    {
        private readonly Mock<IMediator> _mockMediator = new Mock<IMediator>();

        [Fact]
        public void Post_Succeeds()
        {
            var controller = new WorkoutTemplateController(_mockMediator.Object);
            var response = controller.Post(new AddWorkoutTemplateAction
            {
                Name = "Test1",
                Description = "TestDescription"
            });

            Assert.IsType<OkResult>(response);

            _mockMediator
                .Verify(d => d.Send(It.Is<AddWorkoutTemplateAction>(a =>
                    a.Name == "Test1" &&
                    a.Description == "TestDescription"
                    ), default(CancellationToken)), Times.Once());
        }

        [Fact]
        public void Post_Fails()
        {
            var controller = new WorkoutTemplateController(_mockMediator.Object);
            var response = controller.Post(new AddWorkoutTemplateAction
            {
                Name = "Test1",
                Description = "TestDescription"
            });

            _mockMediator
                .Verify(d => d.Send(It.Is<AddWorkoutTemplateAction>(a =>
                    a.Name == "Test1" &&
                    a.Description == "TestDescription"
                    ), default(CancellationToken)), Times.Once());
        }
    }
}