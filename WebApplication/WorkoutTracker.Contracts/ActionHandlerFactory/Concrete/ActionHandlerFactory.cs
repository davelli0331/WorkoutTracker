using WorkoutTracker.Core.Implementation.ActionHandlerFactory.Abstract;
using WorkoutTracker.Core.Implementation.ActionHandlers.Abstract;
using WorkoutTracker.Core.Implementation.ActionHandlers.Concrete.WorkoutTemplateActionHandlers;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.DbContexts.Abstract;

namespace WorkoutTracker.Core.Implementation.ActionHandlerFactory.Concrete
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