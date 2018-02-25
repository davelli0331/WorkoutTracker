using System.Linq;
using System.Threading;
using WorkoutTracker.Core.NetCore.Domain;
using WorkoutTracker.Core.NetCore.Queries.Concrete;
using WorkoutTracker.Core.NetCore.QueryHandlers.Concrete;
using WorkoutTracker.Tests.NetCore.Stubs;
using Xunit;

namespace WorkoutTracker.Tests.NetCore.QueryHandlerTests
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
