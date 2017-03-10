namespace WorkoutTracker.Core.Implementation.DbContexts.Abstract
{
    public interface ICommandDbContext
    {
        int SaveChanges();
        void Create<TEntity>(TEntity entity) where TEntity : class;
    }
}