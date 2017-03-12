using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WorkoutTracker.Core.Implementation.DbContexts.Abstract;
using WorkoutTracker.Core.Implementation.DbContexts.EntityConfigurations;

namespace WorkoutTracker.Core.Implementation.DbContexts.Concrete
{
    public class CommandDbContext : DbContext, ICommandDbContext, IQueryDbContext
    {
        public CommandDbContext()
            : base("WorkoutTrackerdb")
        {
        }

        public void Create<TEntity>(TEntity entity) where TEntity : class
        {
            Set<TEntity>()
                .Add(entity);
        }

        public IEnumerable<TEntity> Query<TEntity>() where TEntity : class
        {
            return Query<TEntity>()
                .ToList();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new WorkoutTemplateConfiguration());
            modelBuilder.Configurations.Add(new WorkoutTemplateExerciseConfiguration());
            modelBuilder.Configurations.Add(new ExerciseConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
