using System.Threading;
using Moq;
using WorkoutTracker.Core.Commands.Handlers;
using WorkoutTracker.Core.Commands.Requests;
using WorkoutTracker.Core.DbContexts.Abstract;
using WorkoutTracker.Core.Domain;
using Xunit;

namespace WorkoutTracker.Tests.CommandTests.ExerciseCommandTests
{

    public class AddExerciseCommandTests
    {
        [Fact]
        public void AddExerciseCommand_Succeeds()
        {
            var context = new Mock<ICommandDbContext>();

            var handler = new AddExerciseCommandHandler(context.Object);
            handler.Handle(new AddExerciseCommandRequest
            {
                ExerciseName = "Test",
                Instruction = "Do the exercise",
                PushPullIndicator = "Push"
            }, CancellationToken.None);

            context.Verify(db => db.Create(It.Is<Exercise>(e =>
                e.ExerciseName == "Test" &&
                e.Instruction == "Do the exercise" &&
                e.PushPullIndicator == "Push"
            )), Times.Once());

            context.Verify(db => db.SaveChanges(), Times.Once());
        }
    }
}
