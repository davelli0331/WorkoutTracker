using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WorkoutTracker.Core.DbContexts.Utility
{
    internal interface IEntityConfiguration<TEntity> where TEntity : class
    {
         void Configure(EntityTypeBuilder<TEntity> entityTypeBuilder);
    }
}
