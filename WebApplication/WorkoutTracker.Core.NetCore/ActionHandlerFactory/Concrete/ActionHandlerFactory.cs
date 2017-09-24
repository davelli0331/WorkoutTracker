using WorkoutTracker.Core.NetCore.ActionHandlerFactory.Abstract;
using WorkoutTracker.Core.NetCore.ActionHandlers.Abstract;
using WorkoutTracker.Core.NetCore.ActionHandlers.Concrete.WorkoutTemplateActionHandlers;
using WorkoutTracker.Core.NetCore.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.NetCore.DbContexts.Abstract;

namespace WorkoutTracker.Core.NetCore.ActionHandlerFactory.Concrete
{
    public class ActionHandlerFactory : IActionHandlerFactory
    {
        private readonly ICommandDbContext _dbContext;

        public ActionHandlerFactory(ICommandDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionHandler<TAction> Buid<TAction>(TAction action)
        {
            if (typeof (TAction) == typeof (AddWorkoutTemplateAction))
            {
                return (IActionHandler<TAction>) new AddWorkoutTemplateActionHandler(_dbContext);
            }

            return null;
        }
    }
}