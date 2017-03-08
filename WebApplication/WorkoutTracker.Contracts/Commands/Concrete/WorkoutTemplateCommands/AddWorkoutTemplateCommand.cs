using WorkoutTracker.Core.Implementation.Commands.Abstract;
using WorkoutTracker.Models;
using WorkoutTracker.Persistence.DbContexts;

namespace WorkoutTracker.CommandsAndQueries.Commands.Concrete.WorkoutTemplateCommands
{
    public class AddWorkoutTemplateCommand : ICommand
    {
        private readonly ICommandDbContext _dbContext;
        private readonly WorkoutTemplate _workoutTemplate;

        public AddWorkoutTemplateCommand(ICommandDbContext dbContext, WorkoutTemplate workoutTemplate)
        {
            _dbContext = dbContext;
            _workoutTemplate = workoutTemplate;
        }

        public void Execute()
        {
            _dbContext.Create(_workoutTemplate);
            _dbContext.SaveChanges();
        }
    }
}
