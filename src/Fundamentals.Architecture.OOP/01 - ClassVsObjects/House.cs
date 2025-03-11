namespace Fundamentals.Architecture.OOP.ClassVsObjects
{
    // Atributos (Propriedads)
    public class House
    {
        public string Color { get; set; }
        public int NumberOfRooms { get; set; }
        public double Size { get; set; }

        // Construtor
        public House(string color, int numberOfRooms, double size)
        {
            Color = color;
            NumberOfRooms = numberOfRooms;
            Size = size;
        }

        // Métodos
        public void OpenDoor()
        {
            Console.WriteLine("A porta foi aberta!");
        }

        public void CloseDoor()
        {
            Console.WriteLine("A porta foi fechada!");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Casa de cor {Color}, com {NumberOfRooms} quartos e {Size}m².");
        }
    }
}
