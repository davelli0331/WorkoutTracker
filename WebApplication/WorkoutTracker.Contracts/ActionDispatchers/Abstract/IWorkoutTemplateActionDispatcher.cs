using WorkoutTracker.Core.Implementation.ActionDispatchers.Utility;

namespace WorkoutTracker.Core.Implementation.ActionDispatchers.Abstract
{
    public interface IWorkoutTemplateActionDispatcher
    {
        DispatchResult Dispatch<TAction>(TAction action);
    }
}
