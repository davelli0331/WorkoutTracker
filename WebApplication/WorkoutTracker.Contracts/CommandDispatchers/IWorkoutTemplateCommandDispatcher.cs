using WorkoutTracker.Contracts.Actions.WorkoutTemplateActions;
using WorkoutTracker.Contracts.CommandDispatchers.Utility;

namespace WorkoutTracker.Contracts.CommandDispatchers
{
    public interface IWorkoutTemplateCommandDispatcher
    {
        DispatchResult Dispatch(AddWorkoutTemplateAction action);
    }
}
