using System;
using WorkoutTracker.Core.Implementation.ActionDispatchers.Abstract;
using WorkoutTracker.Core.Implementation.ActionDispatchers.Utility;
using WorkoutTracker.Core.Implementation.ActionHandlerFactory.Abstract;

namespace WorkoutTracker.Core.Implementation.ActionDispatchers.Concrete
{
    public class WorkoutTemplateActionDispatcher : IWorkoutTemplateActionDispatcher
    {
        private readonly IActionHandlerFactory _factory;

        public WorkoutTemplateActionDispatcher(IActionHandlerFactory factory)
        {
            _factory = factory;
        }

        public DispatchResult Dispatch<TAction>(TAction action)
        {
            var result = new DispatchResult
            {
                Succeeded = true
            };

            try
            {
                _factory.Buid(action).Handle(action);
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
