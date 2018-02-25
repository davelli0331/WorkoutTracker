using Microsoft.EntityFrameworkCore;

namespace WorkoutTracker.Core.NetCore.DbContexts.Utility
{
    internal static class ModelBuilderExtensions
    {
        internal static void AddConfiguration<TEntity>(this ModelBuilder modelBuilder, IEntityConfiguration<TEntity> configuration)
            where TEntity : class
        {
            configuration.Configure(modelBuilder.Entity<TEntity>());
        }
    }
}
