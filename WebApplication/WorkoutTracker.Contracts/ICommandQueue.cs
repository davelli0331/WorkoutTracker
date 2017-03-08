namespace WorkoutTracker.Contracts
{
    public interface ICommandQueue
    {
        void EnqueueCommand(ICommand command);
        void Resolve();
    }
}
