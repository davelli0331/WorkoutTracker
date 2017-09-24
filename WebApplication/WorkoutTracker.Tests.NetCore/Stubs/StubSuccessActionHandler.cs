using WorkoutTracker.Core.NetCore.ActionHandlers.Abstract;

namespace WorkoutTracker.Tests.NetCore.Stubs
{
    public class StubSuccessActionHandler<TAction> : IActionHandler<TAction>
    {
        public void Handle(TAction action)
        {
        }
    }
}
