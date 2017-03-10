﻿namespace WorkoutTracker.Persistence.DbContexts
{
    public interface ICommandDbContext
    {
        void Create<TEntity>(TEntity entity) where TEntity : class;
        void SaveChanges();
    }
}