namespace Fundamentals.Architecture.OOP.Pillars.Abstraction
{
    public class Refrigerator : HomeAppliance
    {
        public Refrigerator(string name, int voltage) : base(name, voltage)
        {

        }

        public override void TurnOn() => Console.WriteLine($"{Name} está ligada.");
        public override void TurnOf() => Console.WriteLine($"{Name} está desligada.");
    }
}
