namespace Fundamentals.Architecture.OOP.Pillars.Inheritance
{
    // Classe base
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Meu nome é {Name} e eu tenho {Age} anos.");
        }
    }
}
