namespace Fundamentals.Architecture.SOLID.DIP.DIP.Violation
{
    public class ClientService
    {
        public string ClientAdd(Client client)
        {
            if (client.Validate())
                return "Dados inválidos";

            var repository = new ClientRepository();
            repository.ClientAdd(client);

            return "Cliente cadastrado com sucesso!";
        }
    }
}
