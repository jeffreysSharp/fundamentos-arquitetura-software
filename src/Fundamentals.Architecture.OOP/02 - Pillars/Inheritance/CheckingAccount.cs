namespace Fundamentals.Architecture.OOP.Pillars.Inheritance
{
    public class CheckingAccount : BankAccount
    {
        public void ShowBalance()
        {
            Console.WriteLine($"Saldo atual : {Balance}."); // Permitido desde que o saldo esteja protegido
        }
    }
}
