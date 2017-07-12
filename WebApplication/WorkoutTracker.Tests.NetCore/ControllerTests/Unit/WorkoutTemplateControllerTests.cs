using System;
using WorkoutTracker.Api.NetCore.Controllers.Concrete;
using WorkoutTracker.Core.NetCore.ActionDispatchers.Abstract;
using WorkoutTracker.Core.NetCore.ActionDispatchers.Utility;
using WorkoutTracker.Core.NetCore.Actions.WorkoutTemplateActions;
using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;

namespace WorkoutTracker.Tests.NetCore.ControllerTests.Unit
{
    public class WorkoutTemplateControllerTests
    {
        private readonly Mock<IWorkoutTemplateActionDispatcher> _mockDispatcher = new Mock<IWorkoutTemplateActionDispatcher>();

        [Fact]
        public void Post_Succeeds()
        {
            _mockDispatcher
                .Setup(d => d.Dispatch(It.IsAny<AddWorkoutTemplateAction>()))
                .Returns(new DispatchResult
                {
                    Succeeded = true
                });

            var controller = new WorkoutTemplateController(_mockDispatcher.Object, null);
            var response = controller.Post(new AddWorkoutTemplateAction
            {
                Name = "Test1",
                Description = "TestDescription"
            });

            Assert.IsType<OkResult>(response);

            _mockDispatcher
                .Verify(d => d.Dispatch(It.Is<AddWorkoutTemplateAction>(a =>
                    a.Name == "Test1" &&
                    a.Description == "TestDescription"
                    )), Times.Once());
        }

        [Fact]
        public void Post_Fails()
        {
            _mockDispatcher
                .Setup(d => d.Dispatch(It.IsAny<AddWorkoutTemplateAction>()))
                .Returns(new DispatchResult
                {
                    Succeeded = false,
                    CaughtException = new Exception("Test exception")
                });

            var controller = new WorkoutTemplateController(_mockDispatcher.Object, null);
            var response = controller.Post(new AddWorkoutTemplateAction
            {
                Name = "Test1",
                Description = "TestDescription"
            });

            //Assert.IsType<ExceptionResult>(response);
            //Assert.True(((ExceptionResult) response).Exception.Message == "Test exception");

            _mockDispatcher
                .Verify(d => d.Dispatch(It.Is<AddWorkoutTemplateAction>(a =>
                    a.Name == "Test1" &&
                    a.Description == "TestDescription"
                    )), Times.Once());
        }
    }
}