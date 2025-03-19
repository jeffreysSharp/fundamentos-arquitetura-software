using Fundamentals.Architecture.DI.Interfaces;

namespace Fundamentals.Architecture.DI.Services
{
    public class OperationService
    {
        public OperationService(
            IOPerationTransient transient,
            IOperationScoped scoped,
            IOperationSingleton singleton,
            IOPerationSingletonInstance singletonInstance
            )
        {
            Transient = transient;
            Scoped = scoped;
            Singleton = singleton;
            SingletonInstance = singletonInstance;
        }

        public IOPerationTransient Transient { get;  }
        public IOperationScoped Scoped { get; }
        public IOperationSingleton Singleton { get; }
        public IOPerationSingletonInstance SingletonInstance { get; }

    }
}
