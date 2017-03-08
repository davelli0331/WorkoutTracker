namespace WorkoutTracker.Contracts.Commands
{
    public interface ICommandQueue
    {
        void EnqueueCommand(ICommand command);
        void Resolve();
    }
}
