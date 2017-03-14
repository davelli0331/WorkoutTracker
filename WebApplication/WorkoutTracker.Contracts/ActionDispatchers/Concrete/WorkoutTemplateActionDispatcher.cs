using System;
using WorkoutTracker.Core.Implementation.ActionDispatchers.Abstract;
using WorkoutTracker.Core.Implementation.ActionDispatchers.Utility;
using WorkoutTracker.Core.Implementation.ActionHandlers.Abstract;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;

namespace WorkoutTracker.Core.Implementation.ActionDispatchers.Concrete
{
    public class WorkoutTemplateActionDispatcher : IWorkoutTemplateActionDispatcher
    {
        private readonly IActionHandler<AddWorkoutTemplateAction> _addHandler;
        private readonly IActionHandler<AddExercisesToWorkoutTemplateAction> _addExercisesHandler;

        public WorkoutTemplateActionDispatcher(
            IActionHandler<AddWorkoutTemplateAction> addHandler,
            IActionHandler<AddExercisesToWorkoutTemplateAction> addExercisesHandler)
        {
            _addHandler = addHandler;
            _addExercisesHandler = addExercisesHandler;
        }

        public DispatchResult Dispatch(AddWorkoutTemplateAction action)
        {
            var result = new DispatchResult
            {
                Succeeded = true
            };

            try
            {
                _addHandler.Handle(action);
            }
            catch (Exception ex)
            {
                result.Succeeded = false;
                result.CaughtException = ex;
            }

            return result;
        }

        public DispatchResult Dispatch(AddExercisesToWorkoutTemplateAction action)
        {
            var result = new DispatchResult
            {
                Succeeded = true
            };

            try
            {
                _addExercisesHandler.Handle(action);
            }
            catch (Exception ex)
            {
                result.Succeeded = false;
                result.CaughtException = ex;
            }

            return result;
        }
    }
}
