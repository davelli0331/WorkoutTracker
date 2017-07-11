using WorkoutTracker.Core.NetCore.Queries.Abstract;

namespace WorkoutTracker.Core.NetCore.QueryDispatcher.Abstract
{
    public interface IWorkoutQueryDispatcher
    {
        TResult Dispatch<TResult>(IQuery<TResult> query);
    }
}
