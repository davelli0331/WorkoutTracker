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

        public void Handle(AddWorkoutTemplateAction command)
        {
            var workoutTemplate = new WorkoutTemplate
            {
                TemplateName =  command.Name,
                TemplateDescription = command.Description
            };

            //_dbContext.DeleteWhere<WorkoutTemplateExercise>(wte => wte.TemplateName == action.Name);
            //_dbContext.CreateRange(action.ExerciseIds
            //    .Select(e => new WorkoutTemplateExercise
            //    {
            //        TemplateName = action.Name,
            //        ExerciseId = e
            //    }));
            //_dbContext.SaveChanges();

            _dbContext.Create(workoutTemplate);
            _dbContext.SaveChanges();
        }
    }
}
