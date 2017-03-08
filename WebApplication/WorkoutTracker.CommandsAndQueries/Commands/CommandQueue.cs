using System.Collections.Generic;
using WorkoutTracker.Contracts;
using WorkoutTracker.Contracts.Commands;

namespace WorkoutTracker.CommandsAndQueries.Commands
{
    public class CommandQueue : ICommandQueue
    {
        private readonly Queue<ICommand> _commands = new Queue<ICommand>();

        public void EnqueueCommand(ICommand command)
        {
            _commands.Enqueue(command);
        }

        public void Resolve()
        {
            while (_commands.Count > 0)
            {
                var command = _commands.Dequeue();
                command.Execute();
            }
        }
    }
}
