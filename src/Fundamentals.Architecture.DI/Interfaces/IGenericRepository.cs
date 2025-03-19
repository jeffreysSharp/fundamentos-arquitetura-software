namespace Fundamentals.Architecture.DI.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T obj);
    }
}
