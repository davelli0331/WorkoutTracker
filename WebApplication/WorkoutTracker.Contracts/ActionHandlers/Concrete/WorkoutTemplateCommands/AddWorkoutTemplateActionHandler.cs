﻿using System.Linq;
using WorkoutTracker.Core.Implementation.ActionHandlers.Abstract;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Models;
using WorkoutTracker.Persistence.DbContexts;

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
                TemplateDescription = command.Description,
                Exercises = command
                    .ExerciseIds
                    .Select(e => new Exercise
                    {
                        ExerciseId = e
                    })
                    .ToList()
            };

            _dbContext.Create(workoutTemplate);
            _dbContext.SaveChanges();
        }
    }
}