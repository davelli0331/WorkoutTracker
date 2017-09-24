using WorkoutTracker.Core.Implementation.ActionHandlers.Abstract;

namespace WorkoutTracker.Tests.Stubs
{
    public class StubSuccessActionHandler<TAction> : IActionHandler<TAction>
    {
        public void Handle(TAction action)
        {
        }
    }
}
