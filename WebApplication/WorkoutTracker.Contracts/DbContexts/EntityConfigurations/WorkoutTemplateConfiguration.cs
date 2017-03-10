using System.Data.Entity.ModelConfiguration;
using WorkoutTracker.Core.Implementation.Domain;

namespace WorkoutTracker.Core.Implementation.DbContexts.EntityConfigurations
{
    internal class WorkoutTemplateConfiguration : EntityTypeConfiguration<WorkoutTemplate>
    {
        internal WorkoutTemplateConfiguration()
        {
            ToTable("Workout.WorkoutTemplate");

            HasKey(w => w.TemplateName);

            Property(w => w.TemplateName)
                .IsRequired()
                .HasMaxLength(30);

            Property(w => w.TemplateDescription)
                .IsRequired()
                .HasMaxLength(300);
        }
    }
}
