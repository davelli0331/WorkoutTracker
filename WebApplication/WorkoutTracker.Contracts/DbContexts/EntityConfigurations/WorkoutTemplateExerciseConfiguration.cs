using System.Data.Entity.ModelConfiguration;
using WorkoutTracker.Core.Implementation.Domain;

namespace WorkoutTracker.Core.Implementation.DbContexts.EntityConfigurations
{
    public class WorkoutTemplateExerciseConfiguration : EntityTypeConfiguration<WorkoutTemplateExercise>
    {
        public WorkoutTemplateExerciseConfiguration()
        {
            ToTable("Workout", "WorkoutTemplateExercise");

            HasKey(e => new
            {
                e.TemplateName,
                e.ExerciseId
            });
        }
    }
}
