using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace WorkoutTracker.Core.Implementation.DbContexts.Abstract
{
    public interface ICommandDbContext
    {
        int SaveChanges();
        void Create<TEntity>(TEntity entity) where TEntity : class;
        void DeleteWhere<TEntity>(Expression<Func<TEntity, bool>> deletePredicates) where TEntity : class;
        void CreateRange<TEntity>(IEnumerable<TEntity> enumerable) where TEntity : class;
    }
}