#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Results;
using Moq;
using WorkoutTracker.Api.Controllers.Concrete;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.CommandDispatchers.Abstract;
using WorkoutTracker.Core.Implementation.CommandDispatchers.Utility;
using Xunit;

#endregion

namespace WorkoutTracker.Tests.ControllerTests.Unit
{
    public class WorkoutTemplateControllerTests
    {
        private readonly Mock<IWorkoutTemplateCommandDispatcher> _mockDispatcher = new Mock<IWorkoutTemplateCommandDispatcher>();

        [Fact]
        public void Post_Succeeds()
        {
            _mockDispatcher
                .Setup(d => d.Dispatch(It.IsAny<AddWorkoutTemplateAction>()))
                .Returns(new DispatchResult
                {
                    Succeeded = true
                });

            var controller = new WorkoutTemplateController(_mockDispatcher.Object);
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

            var controller = new WorkoutTemplateController(_mockDispatcher.Object);
            var response = controller.Post(new AddWorkoutTemplateAction
            {
                Name = "Test1",
                Description = "TestDescription"
            });

            Assert.IsType<ExceptionResult>(response);
            Assert.True(((ExceptionResult) response).Exception.Message == "Test exception");

            _mockDispatcher
                .Verify(d => d.Dispatch(It.Is<AddWorkoutTemplateAction>(a =>
                    a.Name == "Test1" &&
                    a.Description == "TestDescription"
                    )), Times.Once());
        }
    }
}