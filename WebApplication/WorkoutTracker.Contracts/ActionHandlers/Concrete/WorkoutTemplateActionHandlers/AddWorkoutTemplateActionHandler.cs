using WorkoutTracker.Core.Implementation.ActionHandlers.Abstract;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.DbContexts.Abstract;
using WorkoutTracker.Core.Implementation.Domain;

namespace WorkoutTracker.Core.Implementation.ActionHandlers.Concrete.WorkoutTemplateActionHandlers
{
    public class AddWorkoutTemplateActionHandler : IActionHandler<AddWorkoutTemplateAction>
    {
        private readonly ICommandDbContext _dbContext;

        public AddWorkoutTemplateActionHandler(ICommandDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Handle(AddWorkoutTemplateAction action)
        {
            var workoutTemplate = new WorkoutTemplate
            {
                TemplateName =  action.Name,
                TemplateDescription = action.Description
            };

            _dbContext.Create(workoutTemplate);
            _dbContext.DeleteWhere<WorkoutTemplateExercise>(wte => wte.TemplateName == action.Name);
            _dbContext.CreateRange(action.Exercises);
            _dbContext.SaveChanges();
        }
    }
}
