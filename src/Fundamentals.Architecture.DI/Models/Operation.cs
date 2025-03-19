using Fundamentals.Architecture.DI.Interfaces;

namespace Fundamentals.Architecture.DI.Models
{
    public class Operation : IOPerationTransient,
        IOperationScoped,
        IOperationSingleton,
        IOPerationSingletonInstance
    {
        public Operation() : this(Guid.NewGuid())
        {

        }

        public Operation(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}
