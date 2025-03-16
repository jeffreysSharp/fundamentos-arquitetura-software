namespace Fundamentals.Architecture.SOLID.LSP.LSP.Solution
{
    public class AreaCalculation
    {
        private static void GetAreaParallelogram(Parallelogram parallelogram)
        {
            Console.Clear();
            Console.WriteLine("Cálculo da área do Retângulo");
            Console.WriteLine(parallelogram.Height + " * " + parallelogram.Width);
            Console.WriteLine();
            Console.WriteLine(parallelogram.Area);
            Console.ReadKey();
        }

        public static void Calculate()
        {
            var square = new Square(5, 5);
            var rectangle = new Rectangle(10, 5);

            GetAreaParallelogram(square);
            GetAreaParallelogram(rectangle);
        }
    }
}
