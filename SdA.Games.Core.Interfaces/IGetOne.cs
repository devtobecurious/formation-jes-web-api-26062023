namespace SdA.Games.Core.Interfaces
{
    public interface IGetOne<T> where T : class
    {
        T Get();
    }
}
