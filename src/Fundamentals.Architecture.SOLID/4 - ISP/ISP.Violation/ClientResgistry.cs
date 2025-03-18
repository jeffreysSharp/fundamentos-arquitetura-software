namespace Fundamentals.Architecture.SOLID.ISP.ISP.Violation
{
    public class ClientResgistry : IRegistry
    {
        public void Save()
        {
            throw new NotImplementedException();
        }

        public void SendMail()
        {
            throw new NotImplementedException("Esse método não serve para Cadastro de Produtos");
        }

        public void Validator()
        {
            throw new NotImplementedException();
        }
    }
}
