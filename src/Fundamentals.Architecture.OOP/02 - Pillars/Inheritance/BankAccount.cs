namespace Fundamentals.Architecture.OOP.Pillars.Inheritance
{
    public class BankAccount
    {
        public string Owner { get; set; }
        protected decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}
