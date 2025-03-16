using Fundamentals.Architecture.SOLID.LSP.LSP.Solution;
using Fundamentals.Architecture.SOLID.OCP.OCP.Solution.ExtensionMethods;

namespace SOLID
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Escolha a operação");
            Console.WriteLine("1 - OCP");
            Console.WriteLine("2 - LSP");

            var options = Console.ReadKey();

            switch (options.KeyChar)
            {
                case '1':
                    Atm.Operations();
                    break;
                case '2':
                    AreaCalculation.Calculate();
                    break;
            }
        }
    }
}