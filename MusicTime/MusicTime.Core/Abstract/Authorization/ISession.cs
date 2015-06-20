namespace MusicTime.Core.Abstract.Authorization
{
    public interface ISession
    {
        string CurrentUser { get; set; }
    }
}