using WorkoutTracker.CommandsAndQueries.Commands.Abstract;

namespace WorkoutTracker.CommandsAndQueries
{
    public interface ICommandFactory
    {
        ICommand Build<TCommand, TAction>(TAction action);
    }
}
