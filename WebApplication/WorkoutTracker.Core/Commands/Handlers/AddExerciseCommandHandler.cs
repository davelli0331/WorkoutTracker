using MediatR;
using WorkoutTracker.Core.Commands.Requests;
using WorkoutTracker.Core.DbContexts.Abstract;
using WorkoutTracker.Core.Domain;

namespace WorkoutTracker.Core.Commands.Handlers
{
    public class AddExerciseCommandHandler : RequestHandler<AddExerciseCommandRequest>
    {
        private readonly ICommandDbContext _dbContext;

        public AddExerciseCommandHandler(ICommandDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected override void HandleCore(AddExerciseCommandRequest message)
        {
            _dbContext.Create(new Exercise
            {
                ExerciseName =  message.ExerciseName,
                Instruction = message.Instruction,
                PushPullIndicator = message.PushPullIndicator
            });

            _dbContext.SaveChanges();
        }
    }
}
