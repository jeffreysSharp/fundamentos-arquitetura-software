using Fundamentals.Architecture.OOP.Pillars.Polimorphism;

namespace Fundamentals.Architecture.OOP.Pillars.Encapsulation
{
    public class CoffeeAutomation
    {
        public void ServingCoffee()
        {
            var coffeeMaker = new CoffeeMaker();
            coffeeMaker.TurnOn();
            coffeeMaker.PrepareCoffee();
            coffeeMaker.TurnOf();
        }
    }
}
