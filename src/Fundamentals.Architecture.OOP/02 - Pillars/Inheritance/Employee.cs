// Classe derivada
namespace Fundamentals.Architecture.OOP.Pillars.Inheritance
{
    public class Employee : Person
    {
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public void Work()
        {
            Console.WriteLine($"{Name} está trabalhando como {Position}.");
        }
    }
}
