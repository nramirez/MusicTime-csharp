namespace MusicTime.Core.Abstract.Handlers.Queries
{
    public interface IQueryHandler<in TQuery, out TResult>
    {
        TResult Handle(TQuery query);
    }
}