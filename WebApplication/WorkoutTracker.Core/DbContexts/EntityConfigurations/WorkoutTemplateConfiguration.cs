﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkoutTracker.Core.DbContexts.Utility;
using WorkoutTracker.Core.Domain;

namespace WorkoutTracker.Core.DbContexts.EntityConfigurations
{
    internal class WorkoutTemplateConfiguration : IEntityConfiguration<WorkoutTemplate>
    {
        public void Configure(EntityTypeBuilder<WorkoutTemplate> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("WorkoutTemplate", "Workout");

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
