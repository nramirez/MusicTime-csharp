namespace MusicTime.Core.Concrete.Handlers.Queries
{
    public interface IQueryHandler<in TQuery, out TResult>
    {
        TResult Handle(TQuery query);
    }
}