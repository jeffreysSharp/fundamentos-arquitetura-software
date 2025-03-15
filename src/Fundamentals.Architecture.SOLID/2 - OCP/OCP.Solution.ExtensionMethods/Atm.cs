namespace Fundamentals.Architecture.SOLID.OCP.OCP.Solution.ExtensionMethods
{
    public class Atm
    {
        public static void Operations()
        {
            OperationsMenu();

            var options = Console.ReadKey();
            var returns = string.Empty;
            var accountDebit = DebitData();

            switch (options.KeyChar)
            {
                case '1':
                    Console.WriteLine("Efetuando Operação em Conta Corrente");
                    returns = accountDebit.RemoveCurrentAccount();
                    break;
                case '2':
                    Console.WriteLine("Efetuando Operação em Conta Poupança");
                    returns = accountDebit.RemoveSavingsAccount();
                    break;
                case '3':
                    Console.WriteLine("Efetuando Operação em Conta Investimento");
                    returns = accountDebit.RemoveInvestmentAccount();
                    break;
            }

            TransactionReturn(returns);
        }

        private static void OperationsMenu()
        {
            Console.Clear();
            Console.WriteLine(" Caixa eletrônico OCP - SOLID");
            Console.WriteLine(" Escolha sua opção");
            Console.WriteLine();
            Console.WriteLine("1 - Saque Conta Corrente");
            Console.WriteLine("2 - Saque Conta Poupança");
            Console.WriteLine("3 - Saque conta Investimento");
        }

        private static AccountDebit DebitData()
        {

            Console.WriteLine("");
            Console.WriteLine(".........................................");
            Console.WriteLine("Digite a Conta");
            var account = Console.ReadLine();
            Console.WriteLine("Digite o Valor");
            var value = Convert.ToDecimal(Console.ReadLine());

            var accountDebit = new AccountDebit()
            {
                AccountNumber = account,
                Value = value
            };

            return accountDebit;
        }

        private static void TransactionReturn(string returns)
        {
            Console.WriteLine();
            Console.WriteLine("Sucesso! Transação: " + returns);
            Console.ReadKey();
        }

    }
}
