using WorkoutTracker.Core.Implementation.Queries.Abstract;

namespace WorkoutTracker.Core.Implementation.QueryHandlers.Abstract
{
    public interface IQueryHandler<TQuery, TResult>
        where TQuery : IQuery<TResult>
    {
        TResult Handle(TQuery query);
    }
}
