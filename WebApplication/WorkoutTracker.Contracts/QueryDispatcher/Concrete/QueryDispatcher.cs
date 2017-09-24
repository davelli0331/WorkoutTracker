using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutTracker.Core.Implementation.Queries.Abstract;
using WorkoutTracker.Core.Implementation.QueryDispatcher.Abstract;

namespace WorkoutTracker.Core.Implementation.QueryDispatcher.Concrete
{
    public class QueryDispatcher : IWorkoutQueryDispatcher
    {
        public TResult Dispatch<TResult>(IQuery<TResult> query)
        {
            throw new NotImplementedException();
        }
    }
}
