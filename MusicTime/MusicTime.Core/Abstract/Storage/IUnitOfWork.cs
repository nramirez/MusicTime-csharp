namespace MusicTime.Core.Abstract.Storage
{
    public interface IUnitOfWork
    {
        int Commit();
    }
}