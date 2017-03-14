using WorkoutTracker.Core.Implementation.ActionHandlers.Abstract;

namespace WorkoutTracker.Core.Implementation.ActionHandlerFactory.Abstract
{
    public interface IActionHandlerFactory
    {
        IActionHandler<TAction> Buid<TAction>(TAction action);
    }
}