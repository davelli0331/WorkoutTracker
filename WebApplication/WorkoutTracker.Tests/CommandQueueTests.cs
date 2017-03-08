using Moq;
using System;
using WorkoutTracker.CommandsAndQueries.Commands;
using WorkoutTracker.Contracts;
using Xunit;

namespace WorkoutTracker.Tests
{
    public class CommandQueueTests
    { 
        [Fact]
        public void CommandQueue_Single_Command_Succeeds()
        {
            var command = new Mock<ICommand>();
            var queue = new CommandQueue();

            queue.EnqueueCommand(command.Object);
            queue.Resolve();

            command.Verify(c => c.Execute(), Times.Once());
        }

        [Fact]
        public void CommandQueue_Multiple_Commands_Succeeds()
        {
            var command1 = new Mock<ICommand>();
            var command2 = new Mock<ICommand>();
            var command3 = new Mock<ICommand>();

            var queue = new CommandQueue();

            queue.EnqueueCommand(command1.Object);
            queue.EnqueueCommand(command2.Object);
            queue.EnqueueCommand(command3.Object);

            queue.Resolve();

            command1.Verify(c => c.Execute(), Times.Once());
            command2.Verify(c => c.Execute(), Times.Once());
            command3.Verify(c => c.Execute(), Times.Once());
        }

        [Fact]
        public void CommandQueue_Multiple_Commands_First_Fails()
        {
            var command1 = new Mock<ICommand>();
            var command2 = new Mock<ICommand>();
            var command3 = new Mock<ICommand>();

            command2
                .Setup(c => c.Execute())
                .Throws(new Exception());

            var queue = new CommandQueue();

            queue.EnqueueCommand(command1.Object);
            queue.EnqueueCommand(command2.Object);
            queue.EnqueueCommand(command3.Object);

            try
            {
                queue.Resolve();
                Assert.True(false);
            }
            catch
            {
                Assert.True(true);
            }
            finally
            {
                command1.Verify(c => c.Execute(), Times.Once());
                command2.Verify(c => c.Execute(), Times.Once());
                command3.Verify(c => c.Execute(), Times.Never());
            }
        }
    }
}
