using System.Data.Entity.ModelConfiguration;
using WorkoutTracker.Core.Implementation.Domain;

namespace WorkoutTracker.Core.Implementation.DbContexts.EntityConfigurations
{
    public class ExerciseConfiguration : EntityTypeConfiguration<Exercise>
    {
        public ExerciseConfiguration()
        {
            ToTable("Exercise.Exercise");

            HasKey(e => e.ExerciseId);

            Property(e => e.ExerciseName)
                .IsRequired()
                .HasMaxLength(300);

            Property(e => e.Instruction)
                .IsRequired();

            Property(e => e.PushPullIndicator)
                .IsRequired()
                .HasMaxLength(4);
        }
    }
}
