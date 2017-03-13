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
        public WorkoutTemplateActionDispatcher(IActionHandler<AddWorkoutTemplateAction> addHandler)
        {
            _addHandler = addHandler;
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
    }
}
