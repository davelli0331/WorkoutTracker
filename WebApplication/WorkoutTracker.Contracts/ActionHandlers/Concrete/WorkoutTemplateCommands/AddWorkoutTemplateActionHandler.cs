using System.Linq;
using WorkoutTracker.Core.Implementation.ActionHandlers.Abstract;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.DbContexts.Abstract;
using WorkoutTracker.Core.Implementation.Domain;

namespace WorkoutTracker.Core.Implementation.ActionHandlers.Concrete.WorkoutTemplateCommands
{
    public class AddWorkoutTemplateActionHandler : IActionHandler<AddWorkoutTemplateAction>
    {
        private readonly ICommandDbContext _dbContext;

        public AddWorkoutTemplateActionHandler(ICommandDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Handle(AddWorkoutTemplateAction command)
        {
            var workoutTemplate = new WorkoutTemplate
            {
                TemplateName =  command.Name,
                TemplateDescription = command.Description
            };

            _dbContext.Create(workoutTemplate);
            _dbContext.SaveChanges();
        }
    }
}
