﻿namespace Fundamentals.Architecture.SOLID.OCP.OCP.Solution
{
    public class DebitSavingsAccount : AccountDebit
    {
        public override string Debit(decimal value, string account)
        {
            return TransactionFormat();
        }
    }
}
