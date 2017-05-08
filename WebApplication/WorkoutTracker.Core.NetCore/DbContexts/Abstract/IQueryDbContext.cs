using System.Collections.Generic;

namespace WorkoutTracker.Core.Implementation.DbContexts.Abstract
{
    public interface IQueryDbContext
    {
        IEnumerable<TEntity> Query<TEntity>() where TEntity : class;
    }
}
