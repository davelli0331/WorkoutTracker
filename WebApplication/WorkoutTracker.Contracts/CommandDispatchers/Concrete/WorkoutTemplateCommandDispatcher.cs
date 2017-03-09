using System;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.CommandDispatchers.Abstract;
using WorkoutTracker.Core.Implementation.CommandDispatchers.Utility;
using WorkoutTracker.Core.Implementation.Commands.Abstract;

namespace WorkoutTracker.Core.Implementation.CommandDispatchers.Concrete
{
    public class WorkoutTemplateCommandDispatcher : IWorkoutTemplateCommandDispatcher
    {
        private readonly IActionHandler<AddWorkoutTemplateAction> _addHandler;
        public WorkoutTemplateCommandDispatcher(IActionHandler<AddWorkoutTemplateAction> addHandler)
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
