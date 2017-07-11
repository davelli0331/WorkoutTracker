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
            var results = handler.Handle(new WorkoutTemplateQuery());

            Assert.Equal(1, results.Count());
        }
    }
}
