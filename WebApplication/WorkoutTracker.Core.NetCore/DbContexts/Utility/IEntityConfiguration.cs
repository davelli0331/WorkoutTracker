using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WorkoutTracker.Core.NetCore.DbContexts.Utility
{
    internal interface IEntityConfiguration<TEntity> where TEntity : class
    {
         void Configure(EntityTypeBuilder<TEntity> entityTypeBuilder);
    }
}
