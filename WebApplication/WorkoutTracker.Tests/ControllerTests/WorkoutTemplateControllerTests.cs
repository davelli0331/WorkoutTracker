using System.Collections.Generic;
using System.Web.Http.Results;
using Moq;
using WorkoutTracker.Api.Controllers;
using WorkoutTracker.Api.ViewModels.WorkoutTemplate;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.CommandDispatchers.Abstract;
using WorkoutTracker.Core.Implementation.CommandDispatchers.Utility;
using Xunit;

namespace WorkoutTracker.Tests.ControllerTests
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
            var response = controller.Post(new Add
            {
                WorkoutTemplateName = "Test1",
                Exercises = new List<int>()
            });

            Assert.IsType<OkResult>(response);
        }
    }
}
