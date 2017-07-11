using System;
using WorkoutTracker.Core.NetCore.ActionDispatchers.Abstract;
using WorkoutTracker.Core.NetCore.ActionDispatchers.Utility;
using WorkoutTracker.Core.NetCore.ActionHandlerFactory.Abstract;

namespace WorkoutTracker.Core.NetCore.ActionDispatchers.Concrete
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
