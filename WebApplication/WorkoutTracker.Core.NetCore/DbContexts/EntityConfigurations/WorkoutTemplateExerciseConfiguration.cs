using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkoutTracker.Core.Implementation.Domain;
using WorkoutTracker.Core.NetCore.DbContexts.Utility;
using Microsoft.EntityFrameworkCore;

namespace WorkoutTracker.Core.Implementation.DbContexts.EntityConfigurations
{
    public class WorkoutTemplateExerciseConfiguration : IEntityConfiguration<WorkoutTemplateExercise>
    {
        public WorkoutTemplateExerciseConfiguration()
        {
            
        }

        public void Configure(EntityTypeBuilder<WorkoutTemplateExercise> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("Workout.WorkoutTemplateExercise");

            entityTypeBuilder.HasKey(e => new
            {
                e.TemplateName,
                e.ExerciseId
            });
        }
    }
}
