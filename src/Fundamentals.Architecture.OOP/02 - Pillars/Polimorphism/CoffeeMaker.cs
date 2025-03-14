using Fundamentals.Architecture.OOP.Pillars.Abstraction;

namespace Fundamentals.Architecture.OOP.Pillars.Polimorphism
{
    public class CoffeeMaker : HomeAppliance
    {
        public CoffeeMaker(string name, int voltage) 
            : base(name, voltage) { }
        public CoffeeMaker() 
            : base("Padrão", 220) { }


        public override void TurnOn()
        {
            Console.WriteLine($"{Name} está ligada, verificando recipiente de água...");
        }

        public override void TurnOf()
        {
            Console.WriteLine($"{Name} está desligada, resfriando o aquecedor...");
        }

        private static void HeatWater() => Console.WriteLine($"Aquecendo a água...");
        private static void GrindingGrains() => Console.WriteLine($"Moendo os grãos...");

        public void PrepareCoffee()
        {
            HeatWater();
            GrindingGrains();
            Console.WriteLine("Café está pronto");
        }
    }
}
