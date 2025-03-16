namespace Fundamentals.Architecture.SOLID.LSP.LSP.Solution
{
    public class Square : Parallelogram
    {
        public Square(int height, int width)
            : base(height, width)
        {
            if (width != height)
                throw new ArgumentException("Os dois lados do quadrado precisam ser iguais");
        }
    }
}
