using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkoutTracker.Core.DbContexts.Utility;
using WorkoutTracker.Core.Domain;

namespace WorkoutTracker.Core.DbContexts.EntityConfigurations
{
    public class WorkoutTemplateExerciseConfiguration : IEntityConfiguration<WorkoutTemplateExercise>
    {
        public void Configure(EntityTypeBuilder<WorkoutTemplateExercise> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("WorkoutTemplateExercise", "Workout");

            entityTypeBuilder.HasKey(e => new
            {
                e.TemplateName,
                e.ExerciseId
            });
        }
    }
}
