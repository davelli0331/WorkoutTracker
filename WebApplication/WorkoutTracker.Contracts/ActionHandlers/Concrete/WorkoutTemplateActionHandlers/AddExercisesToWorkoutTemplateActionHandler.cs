using System.Linq;
using WorkoutTracker.Core.Implementation.ActionHandlers.Abstract;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.DbContexts.Abstract;
using WorkoutTracker.Core.Implementation.Domain;

namespace WorkoutTracker.Core.Implementation.ActionHandlers.Concrete.WorkoutTemplateActionHandlers
{
    public class AddExercisesToWorkoutTemplateActionHandler : IActionHandler<AddExercisesToWorkoutTemplateAction>
    {
        private readonly ICommandDbContext _dbContext;

        public AddExercisesToWorkoutTemplateActionHandler(ICommandDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Handle(AddExercisesToWorkoutTemplateAction action)
        {
            _dbContext.DeleteWhere<WorkoutTemplateExercise>(wte => wte.TemplateName == action.Name);
            _dbContext.CreateRange(action.ExerciseIds
                .Select(e => new WorkoutTemplateExercise
                {
                    TemplateName = action.Name,
                    ExerciseId = e
                }));
            _dbContext.SaveChanges();
        }
    }
}
