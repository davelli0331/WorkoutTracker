using WorkoutTracker.Core.NetCore.ActionDispatchers.Utility;

namespace WorkoutTracker.Core.NetCore.ActionDispatchers.Abstract
{
    public interface IWorkoutTemplateActionDispatcher
    {
        DispatchResult Dispatch<TAction>(TAction action);
    }
}
