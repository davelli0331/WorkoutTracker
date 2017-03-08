using WorkoutTracker.Dispatchers.Actions.WorkoutTemplateActions;
using WorkoutTracker.Dispatchers.CommandDispatchers.Utility;

namespace WorkoutTracker.Dispatchers.CommandDispatchers.Abstract
{
    public interface IWorkoutTemplateCommandDispatcher
    {
        DispatchResult Dispatch(AddWorkoutTemplateAction action);
    }
}
