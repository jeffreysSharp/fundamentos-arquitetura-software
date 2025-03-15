﻿namespace Fundamentals.Architecture.SOLID.OCP.OCP.Solution.ExtensionMethods
{
    public class AccountDebit
    {
        public string AccountNumber { get; set; }
        public decimal Value { get; set; }
        public string TransactionNumber { get; set; }

        public string TransactionFormat()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVXWYZ";
            var random = new Random();
            TransactionNumber = new string(Enumerable.Repeat(chars, 15)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return TransactionFormat();
        }
    }
}
