namespace Fundamentals.Architecture.SOLID.DIP.DIP.Solution.Interfaces
{
    public interface IEmailService
    {
        void Send(string from, string to, string subjet, string message);
    }
}
