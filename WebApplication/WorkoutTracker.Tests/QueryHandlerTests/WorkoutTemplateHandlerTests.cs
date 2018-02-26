using System.Threading;
using WorkoutTracker.Core.Domain;
using WorkoutTracker.Core.Queries.Handlers;
using WorkoutTracker.Core.Queries.Requests;
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
            var results = handler.Handle(new WorkoutTemplateQueryRequest(), CancellationToken.None).Result;

            Assert.Single(results);
        }
    }
}
