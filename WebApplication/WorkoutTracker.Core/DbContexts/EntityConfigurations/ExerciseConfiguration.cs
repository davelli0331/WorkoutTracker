using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkoutTracker.Core.NetCore.DbContexts.Utility;
using WorkoutTracker.Core.NetCore.Domain;

namespace WorkoutTracker.Core.NetCore.DbContexts.EntityConfigurations
{
    public class ExerciseConfiguration : IEntityConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.ToTable("Exercise", "Exercise");

            builder.HasKey(e => e.ExerciseId);

            builder.Property(e => e.ExerciseName)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(e => e.Instruction)
                .IsRequired();

            builder.Property(e => e.PushPullIndicator)
                .IsRequired()
                .HasMaxLength(4);
        }
    }
}
