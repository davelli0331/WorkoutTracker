using System.Collections.Generic;

namespace WorkoutTracker.Core.NetCore.DbContexts.Abstract
{
    public interface IQueryDbContext
    {
        IEnumerable<TEntity> Query<TEntity>() where TEntity : class;
    }
}
