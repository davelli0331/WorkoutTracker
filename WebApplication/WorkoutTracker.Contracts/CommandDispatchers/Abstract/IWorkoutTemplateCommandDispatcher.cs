using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.CommandDispatchers.Utility;

namespace WorkoutTracker.Core.Implementation.CommandDispatchers.Abstract
{
    public interface IWorkoutTemplateCommandDispatcher
    {
        DispatchResult Dispatch(AddWorkoutTemplateAction action);
    }
}
