using WorkoutTracker.Core.Implementation.ActionDispatchers.Utility;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;

namespace WorkoutTracker.Core.Implementation.ActionDispatchers.Abstract
{
    public interface IWorkoutTemplateActionDispatcher
    {
        DispatchResult Dispatch(AddWorkoutTemplateAction action);
        DispatchResult Dispatch(AddExercisesToWorkoutTemplateAction action);
    }
}
