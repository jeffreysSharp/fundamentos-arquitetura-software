using Fundamentals.Architecture.DI.Interfaces;
using Fundamentals.Architecture.DI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fundamentals.Architecture.DI.Controllers
{
    public class RealLifeController : Controller
    {
        private readonly IClientService _clientService;

        public RealLifeController(IClientService clientService)
        {
            _clientService = clientService;
        }

        public void Index()
        {
            _clientService.ClientAdd(new Client());
        }
    }
}
