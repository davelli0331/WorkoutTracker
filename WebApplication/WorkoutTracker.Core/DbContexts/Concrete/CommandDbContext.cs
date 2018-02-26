using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using WorkoutTracker.Core.DbContexts.Abstract;
using WorkoutTracker.Core.DbContexts.EntityConfigurations;
using WorkoutTracker.Core.DbContexts.Utility;

namespace WorkoutTracker.Core.DbContexts.Concrete
{
    public class WorkoutDbContext : DbContext, ICommandDbContext, IQueryDbContext
    {
        private readonly string _connectionString = @"Server=C05102\MSSQL2016;Database=WorkoutTracker;Trusted_Connection=True;";

        public WorkoutDbContext()
        {
        }

        public WorkoutDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Create<TEntity>(TEntity entity) where TEntity : class
        {
            Set<TEntity>()
                .Add(entity);
        }

        public void CreateRange<TEntity>(IEnumerable<TEntity> enumerable) where TEntity : class
        {
            if (enumerable != null)
            {
                foreach (var entity in enumerable)
                {
                    Set<TEntity>()
                        .Add(entity);
                }
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
            optionsBuilder.UseSqlServer(_connectionString);
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
