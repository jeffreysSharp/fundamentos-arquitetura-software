namespace Fundamentals.Architecture.SOLID.OCP.OCP.Solution.ExtensionMethods
{
    public static class DebitInvestmentAccount
    {
        public static string RemoveInvestmentAccount(this AccountDebit accountDebit)
        {
            return accountDebit.TransactionFormat();
        }
    }
}
