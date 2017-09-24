using System.Linq;
using WorkoutTracker.Core.Implementation.Domain;
using WorkoutTracker.Core.Implementation.Queries.Concrete;
using WorkoutTracker.Core.Implementation.QueryHandlers.Concrete;
using WorkoutTracker.Tests.Stubs;
using Xunit;

namespace WorkoutTracker.Tests.QueryHandlerTests
{
    public class WorkoutTemplateHandlerTests
    {
        [Fact]
        public void Generic_Query_Succeeds()
        {
            var dbContext = new StubQueryDbContext(new WorkoutTemplate());
                
            var handler = new WorkoutTemplateQueryHandler(dbContext);
            var results = handler.Handle(new WorkoutTemplateQuery());

            Assert.Equal(1, results.Count());
        }
    }
}
