using System;
using WorkoutTracker.CommandsAndQueries.Commands.Concrete.WorkoutTemplateCommands;
using WorkoutTracker.Dispatchers.Actions.WorkoutTemplateActions;
using WorkoutTracker.Dispatchers.CommandDispatchers.Abstract;
using WorkoutTracker.Dispatchers.CommandDispatchers.Utility;
using WorkoutTracker.Models;
using WorkoutTracker.Persistence.DbContexts;

namespace WorkoutTracker.Dispatchers.CommandDispatchers.Concrete
{
    public class WorkoutTemplateCommandDispatcher : IWorkoutTemplateCommandDispatcher
    {
        private readonly ICommandDbContext _context;
        public WorkoutTemplateCommandDispatcher(ICommandDbContext context)
        {
            _context = context;
        }

        public DispatchResult Dispatch(AddWorkoutTemplateAction action)
        {
            var result = new DispatchResult
            {
                Succeeded = true
            };

            var command = new AddWorkoutTemplateCommand(_context, new WorkoutTemplate());

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
