using Fundamentals.Architecture.DI.Interfaces;
using Fundamentals.Architecture.DI.Models;

namespace Fundamentals.Architecture.DI.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void ClientAdd(Client client)
        {
            _clientRepository.ClientAdd(client);
        }
    }
}
