using WorkoutTracker.Core.Implementation.Queries.Abstract;

namespace WorkoutTracker.Core.Implementation.QueryDispatcher.Abstract
{
    public interface IWorkoutQueryDispatcher
    {
        TResult Dispatch<TResult>(IQuery<TResult> query);
    }
}
