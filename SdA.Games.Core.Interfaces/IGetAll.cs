namespace SdA.Games.Core.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        List<T>? GetAll();
    }
}
