using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WorkoutTracker.Core.Implementation.DbContexts.Abstract;
using WorkoutTracker.Core.Implementation.DbContexts.EntityConfigurations;
using WorkoutTracker.Core.NetCore.DbContexts.Utility;

namespace WorkoutTracker.Core.Implementation.DbContexts.Concrete
{
    public class WorkoutDbContext : DbContext, ICommandDbContext, IQueryDbContext
    {
        public void Create<TEntity>(TEntity entity) where TEntity : class
        {
            Set<TEntity>()
                .Add(entity);
        }

        public void CreateRange<TEntity>(IEnumerable<TEntity> enumerable) where TEntity : class
        {
            foreach (var entity in enumerable)
            {
                Set<TEntity>()
                    .Add(entity);
            }
        }

        public void DeleteWhere<TEntity>(Expression<Func<TEntity, bool>> deletePredicates) where TEntity : class
        {
            var toDelete = Set<TEntity>()
                .Where(deletePredicates);

            Set<TEntity>()
                .RemoveRange(toDelete);
        }

        public IEnumerable<TEntity> Query<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DELLXPS13\SQL2016EXPRESS;Database=WorkoutTracker;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new ExerciseConfiguration());
            modelBuilder.AddConfiguration(new WorkoutTemplateConfiguration());
            modelBuilder.AddConfiguration(new WorkoutTemplateExerciseConfiguration());
            modelBuilder.AddConfiguration(new ExerciseConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
