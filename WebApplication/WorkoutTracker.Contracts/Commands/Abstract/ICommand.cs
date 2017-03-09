namespace WorkoutTracker.Core.Implementation.Commands.Abstract
{
    public interface IActionHandler<TAction>
    {
        void Handle(TAction action);
    }
}
