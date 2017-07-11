namespace WorkoutTracker.Core.NetCore.ActionHandlers.Abstract
{
    public interface IActionHandler<TAction>
    {
        void Handle(TAction action);
    }
}
