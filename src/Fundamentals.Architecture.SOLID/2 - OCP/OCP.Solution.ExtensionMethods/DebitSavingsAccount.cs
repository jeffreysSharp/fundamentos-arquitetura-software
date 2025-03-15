namespace Fundamentals.Architecture.SOLID.OCP.OCP.Solution.ExtensionMethods
{
    public static class DebitSavingsAccount
    {
        public static string RemoveSavingsAccount(this AccountDebit accountDebit)
        {
            return accountDebit.TransactionFormat();
        }
    }
}
