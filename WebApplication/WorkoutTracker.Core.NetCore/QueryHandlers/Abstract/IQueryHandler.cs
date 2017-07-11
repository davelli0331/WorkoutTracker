using WorkoutTracker.Core.NetCore.Queries.Abstract;

namespace WorkoutTracker.Core.NetCore.QueryHandlers.Abstract
{
    public interface IQueryHandler<TQuery, TResult>
        where TQuery : IQuery<TResult>
    {
        TResult Handle(TQuery query);
    }
}
