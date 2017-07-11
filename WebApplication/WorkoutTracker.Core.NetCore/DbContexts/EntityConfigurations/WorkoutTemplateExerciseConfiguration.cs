using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkoutTracker.Core.NetCore.DbContexts.Utility;
using WorkoutTracker.Core.NetCore.Domain;

namespace WorkoutTracker.Core.NetCore.DbContexts.EntityConfigurations
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
