using MediatR;
using WorkoutTracker.Core.NetCore.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.NetCore.DbContexts.Abstract;
using WorkoutTracker.Core.NetCore.Domain;

namespace WorkoutTracker.Core.NetCore.ActionHandlers.Concrete.WorkoutTemplateActionHandlers
{
    public class AddWorkoutTemplateActionHandler : RequestHandler<AddWorkoutTemplateAction>
    {
        private readonly ICommandDbContext _dbContext;

        public AddWorkoutTemplateActionHandler(ICommandDbContext dbContext)
        {
            _dbContext = dbContext;
        }

       protected override void HandleCore(AddWorkoutTemplateAction action)
        {
            var workoutTemplate = new WorkoutTemplate
            {
                TemplateName = action.Name,
                TemplateDescription = action.Description
            };

            _dbContext.Create(workoutTemplate);
            _dbContext.DeleteWhere<WorkoutTemplateExercise>(wte => wte.TemplateName == action.Name);
            _dbContext.CreateRange(action.Exercises);
            _dbContext.SaveChanges();
        }
    }
}
