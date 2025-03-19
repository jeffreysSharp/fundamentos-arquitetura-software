using Fundamentals.Architecture.DI.Services;
using Microsoft.AspNetCore.Mvc;

namespace Fundamentals.Architecture.DI.Controllers
{
    public class LifeCycleController : Controller
    {
        public OperationService OperationService { get; }
        public OperationService OperationServiceTwo { get; }

        public LifeCycleController(OperationService operationService,
            OperationService operationServiceTwo)
        {
            OperationService = operationService;
            OperationServiceTwo = operationServiceTwo;
        }

        public string Index()
        {
            return
            "Primeira Instância:" + Environment.NewLine +
                OperationService.Transient.Id + Environment.NewLine +
                OperationService.Scoped.Id + Environment.NewLine +
                OperationService.Singleton.Id + Environment.NewLine +
                OperationService.SingletonInstance.Id + Environment.NewLine +

                Environment.NewLine +
                Environment.NewLine +

                "Segunda Instância: " + Environment.NewLine +
                OperationServiceTwo.Transient.Id + Environment.NewLine +
                OperationServiceTwo.Scoped.Id + Environment.NewLine +
                OperationServiceTwo.Singleton.Id + Environment.NewLine +
                OperationServiceTwo.SingletonInstance.Id + Environment.NewLine;
        }
    }
}
