using System;

namespace WorkoutTracker.Persistence.DbContexts.Concrete
{
    public class CommandDbContext : ICommandDbContext
    {
        public void Create<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
