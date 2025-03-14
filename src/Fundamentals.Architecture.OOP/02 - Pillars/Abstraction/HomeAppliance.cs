namespace Fundamentals.Architecture.OOP.Pillars.Abstraction
{
    public abstract class HomeAppliance
    {
        public string Name { get; set; }
        public int Voltage { get; set; }

        protected HomeAppliance(string name, int voltage)
        {
            Name = name;
            Voltage = voltage;
        }

        public abstract void TurnOn();
        public abstract void TurnOf();
    }
}
