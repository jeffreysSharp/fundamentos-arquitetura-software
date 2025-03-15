namespace Fundamentals.Architecture.SOLID.OCP.OCP.Solution.ExtensionMethods
{
    public static class DebitCurrentAccount
    {
        public static string RemoveCurrentAccount(this AccountDebit accountDebit)
        {
            return accountDebit.TransactionFormat();
        }
    }
}
