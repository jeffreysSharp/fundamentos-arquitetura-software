using Fundamentals.Architecture.SOLID.OCP.OCP.Solution.ExtensionMethods;

namespace SOLID
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Escolha a operação");
            Console.WriteLine("1 - OCP");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    Atm.Operations();
                    break;
            }
        }
    }
}