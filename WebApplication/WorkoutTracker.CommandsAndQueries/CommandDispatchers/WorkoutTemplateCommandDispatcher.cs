using System;
using WorkoutTracker.CommandsAndQueries.Commands.WorkoutTemplateCommands;
using WorkoutTracker.Contracts.Actions.WorkoutTemplateActions;
using WorkoutTracker.Contracts.CommandDispatchers;
using WorkoutTracker.Contracts.CommandDispatchers.Utility;
using WorkoutTracker.Contracts.DbContexts;

namespace WorkoutTracker.CommandsAndQueries.CommandDispatchers
{
    public class WorkoutTemplateCommandDispatcher : IWorkoutTemplateCommandDispatcher
    {
        private readonly ICommandDbContext _dbContext;

        public WorkoutTemplateCommandDispatcher(ICommandDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public DispatchResult Dispatch(AddWorkoutTemplateAction action)
        {
            var result = new DispatchResult
            {
                Succeeded = true
            };

            var command = new AddWorkoutTemplateCommand(_dbContext);
            try
            {
                command.Execute();
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
