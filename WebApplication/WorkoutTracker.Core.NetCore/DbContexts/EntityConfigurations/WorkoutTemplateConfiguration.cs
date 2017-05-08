using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkoutTracker.Core.Implementation.Domain;
using WorkoutTracker.Core.NetCore.DbContexts.Utility;
using Microsoft.EntityFrameworkCore;

namespace WorkoutTracker.Core.Implementation.DbContexts.EntityConfigurations
{
    internal class WorkoutTemplateConfiguration : IEntityConfiguration<WorkoutTemplate>
    {
        public void Configure(EntityTypeBuilder<WorkoutTemplate> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("Workout.WorkoutTemplate");

            entityTypeBuilder.HasKey(w => w.TemplateName);

            entityTypeBuilder.Property(w => w.TemplateName)
                .IsRequired()
                .HasMaxLength(30);

            entityTypeBuilder.Property(w => w.TemplateDescription)
                .IsRequired()
                .HasMaxLength(300);

            entityTypeBuilder.HasMany(w => w.WorkoutTemplateExercises)
                .WithOne(wte => wte.WorkoutTemplate);
        }
    }
}
