using MediatR;
using WorkoutTracker.Core.Commands.Requests;
using WorkoutTracker.Core.DbContexts.Abstract;
using WorkoutTracker.Core.Domain;

namespace WorkoutTracker.Core.Commands.Handlers
{
    public class AddWorkoutTemplateHandler : RequestHandler<AddWorkoutTemplateRequest>
    {
        private readonly ICommandDbContext _dbContext;

        public AddWorkoutTemplateHandler(ICommandDbContext dbContext)
        {
            _dbContext = dbContext;
        }

       protected override void HandleCore(AddWorkoutTemplateRequest action)
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
