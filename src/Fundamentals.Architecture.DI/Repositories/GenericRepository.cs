using Fundamentals.Architecture.DI.Interfaces;

namespace Fundamentals.Architecture.DI.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Add(T obj)
        {
            
        }
    }
}
