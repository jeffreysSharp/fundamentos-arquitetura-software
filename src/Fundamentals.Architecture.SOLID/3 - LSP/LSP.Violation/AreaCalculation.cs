namespace Fundamentals.Architecture.SOLID.LSP.LSP.Violation
{
    public class AreaCalculation
    {
        private static void GetAreaRetangle(Rectangle rectangle)
        {
            Console.Clear();
            Console.WriteLine("Cálculo da área do Retângulo");
            Console.WriteLine(rectangle.Height + " * " + rectangle.Width);
            Console.WriteLine();
            Console.WriteLine(rectangle.Area);
            Console.ReadKey();
        }

        public static void Calculate()
        {
            var square = new Square()
            {
                Height = 10,
                Width = 5
            };

            GetAreaRetangle(square);
        }
    }
}
