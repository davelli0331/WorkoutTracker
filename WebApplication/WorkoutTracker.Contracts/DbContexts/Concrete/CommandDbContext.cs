using System.Data.Entity;
using WorkoutTracker.Core.Implementation.DbContexts.Abstract;
using WorkoutTracker.Core.Implementation.DbContexts.EntityConfigurations;

namespace WorkoutTracker.Core.Implementation.DbContexts.Concrete
{
    public class CommandDbContext : DbContext, ICommandDbContext
    {
        public CommandDbContext()
            : base("WorkoutTrackerdb")
        {
        }

        public void Create<TEntity>(TEntity entity) where TEntity : class
        {
            Set<TEntity>()
                .Add(entity);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new WorkoutTemplateConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
