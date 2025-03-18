using Fundamentals.Architecture.SOLID.DIP.DIP.Solution.Interfaces;

namespace Fundamentals.Architecture.SOLID.DIP.DIP.Solution
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IEmailService _emailService;

        public ClientService(IClientRepository clientRepository, IEmailService emailService)
        {
            _clientRepository = clientRepository;
            _emailService = emailService;
        }

        public string ClientAdd(Client client)
        {
            if (!client.Validate())
                return "Dados inválidos";

            _clientRepository.ClientAdd(client);
            _emailService.Send("jeffreys.sharp@outlook.com", "jeffreys.sharp@outlook.com", "DIP", "DIP - Dependency Inversion Principle");

            return "Cliente Cadastrado com sucesso!";
        }
    }
}
