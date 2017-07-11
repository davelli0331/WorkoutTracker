using System;
using WorkoutTracker.Core.NetCore.Queries.Abstract;
using WorkoutTracker.Core.NetCore.QueryDispatcher.Abstract;

namespace WorkoutTracker.Core.NetCore.QueryDispatcher.Concrete
{
    public class QueryDispatcher : IWorkoutQueryDispatcher
    {
        public TResult Dispatch<TResult>(IQuery<TResult> query)
        {
            throw new NotImplementedException();
        }
    }
}
