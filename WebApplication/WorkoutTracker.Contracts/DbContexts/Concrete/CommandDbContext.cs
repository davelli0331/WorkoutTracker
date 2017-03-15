using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using WorkoutTracker.Core.Implementation.DbContexts.Abstract;
using WorkoutTracker.Core.Implementation.DbContexts.EntityConfigurations;

namespace WorkoutTracker.Core.Implementation.DbContexts.Concrete
{
    public class WorkoutDbContext : DbContext, ICommandDbContext, IQueryDbContext
    {
        public WorkoutDbContext()
            : base("WorkoutTrackerdb")
        {
        }

        public void Create<TEntity>(TEntity entity) where TEntity : class
        {
            Set<TEntity>()
                .Add(entity);
        }

        public void CreateRange<TEntity>(IEnumerable<TEntity> enumerable) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void DeleteWhere<TEntity>(Expression<Func<TEntity, bool>> deletePredicates) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Query<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
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
