using WorkoutTracker.Core.NetCore.ActionHandlers.Abstract;

namespace WorkoutTracker.Core.NetCore.ActionHandlerFactory.Abstract
{
    public interface IActionHandlerFactory
    {
        IActionHandler<TAction> Buid<TAction>(TAction action);
    }
}