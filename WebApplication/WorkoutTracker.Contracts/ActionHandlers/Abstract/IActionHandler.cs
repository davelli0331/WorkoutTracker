namespace WorkoutTracker.Core.Implementation.ActionHandlers.Abstract
{
    public interface IActionHandler<TAction>
    {
        void Handle(TAction action);
    }
}
