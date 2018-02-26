using System.Collections.Generic;

namespace WorkoutTracker.Core.DbContexts.Abstract
{
    public interface IQueryDbContext
    {
        IEnumerable<TEntity> Query<TEntity>() where TEntity : class;
    }
}
