namespace Fundamentals.Architecture.SOLID.OCP.OCP.Violation
{
    public class AccountDebit
    {
        public void Debit(decimal value, string account, AccountType accountType)
        {
            if (accountType == AccountType.CurrentAccount)
            {
                // TODO
                // Débito em conta corrente
            }

            if (accountType == AccountType.SavingsAccount)
            {
                //TODO
                // Validar aníversário da conta
                // Débito em conta poupança
            }
        }
    }
}
