using System.Collections.Generic;
using System.Linq;
using WorkoutTracker.Core.DbContexts.Abstract;
using WorkoutTracker.Core.Domain;

namespace WorkoutTracker.Tests.Stubs
{
    public class StubQueryDbContext : IQueryDbContext
    {
        private readonly WorkoutTemplate[] _workoutTemplates;

        public StubQueryDbContext(params WorkoutTemplate[] workoutTemplates)
        {
            _workoutTemplates = workoutTemplates;
        }

        public IEnumerable<TEntity> Query<TEntity>() where TEntity : class
        {
            return _workoutTemplates.Cast<TEntity>();
        }
    }
}
