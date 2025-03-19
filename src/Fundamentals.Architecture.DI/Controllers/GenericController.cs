using Fundamentals.Architecture.DI.Interfaces;
using Fundamentals.Architecture.DI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fundamentals.Architecture.DI.Controllers
{
    public class GenericController : Controller
    {
        private readonly IGenericRepository<Client> _clientRepository;

        public GenericController(IGenericRepository<Client> clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void Index()
        {
            _clientRepository.Add(new Client());
        }
    }
}
