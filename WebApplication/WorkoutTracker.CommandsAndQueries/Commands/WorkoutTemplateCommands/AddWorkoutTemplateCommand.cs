using System;
using WorkoutTracker.Contracts.DbContexts;

namespace WorkoutTracker.CommandsAndQueries.Commands.WorkoutTemplateCommands
{
    internal class AddWorkoutTemplateCommand
    {
        private readonly ICommandDbContext _dbContext;

        internal AddWorkoutTemplateCommand(ICommandDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        internal void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
