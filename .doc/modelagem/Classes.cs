public class ClassName
{
    // Atributos (Propriedades)
    public int Property1 { get; set; }
    public string Property2 { get; set; }

    // Construtor
    public ClassName(int property1, string property2)
    {
        Property1 = property1;
        Property2 = property2;
    }

    // Método
    public void Method()
    {
        Console.WriteLine("Executando método!");
    }
}


public class House
{
    // Atributos (Propriedades)
    public string Color { get; set; }
    public int NumberOfRooms { get; set; }
    public double Size { get; set; } // Tamanho em metros quadrados

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



class Program
{
    static void Main()
    {
        // Criando um objeto da classe House
        House myHouse = new House("Azul", 3, 120.5);
        
        // Exibindo informações
        myHouse.DisplayInfo();
        
        // Abrindo e fechando a porta
        myHouse.OpenDoor();
        myHouse.CloseDoor();
    }
}

Casa de cor Azul, com 3 quartos e 120.5m².
A porta foi aberta!
A porta foi fechada!

public class House
{
    public string Color { get; set; }
    public int NumberOfRooms { get; set; }
    public double Size { get; set; }

    // Construtor padrão
    public House()
    {
        Color = "Branco";
        NumberOfRooms = 2;
        Size = 80;
    }

    // Construtor com parâmetros
    public House(string color, int numberOfRooms, double size)
    {
        Color = color;
        NumberOfRooms = numberOfRooms;
        Size = size;
    }
}

House house1 = new House();
House house2 = new House("Vermelha", 4, 150);


public class House
{
    private bool isDoorOpen;
    
    public void OpenDoor()
    {
        isDoorOpen = true;
        Console.WriteLine("Porta aberta!");
    }
}

// Base class
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public void Introduce()
    {
        Console.WriteLine($"My name is {Name} and I am {Age} years old.");
    }
}

// Derived class
public class Employee : Person
{
    public string Position { get; set; }
    public decimal Salary { get; set; }
    
    public void Work()
    {
        Console.WriteLine($"{Name} is working as a {Position}.");
    }
}

// Usage
var employee = new Employee
{
    Name = "John",
    Age = 30,
    Position = "Developer",
    Salary = 10000
};

employee.Introduce();
employee.Work();



public class BankAccount
{
    public string Owner { get; set; }
    protected decimal Balance { get; set; }
    
    public void Deposit(decimal amount)
    {
        Balance += amount;
    }
}

public class CheckingAccount : BankAccount
{
    public void ShowBalance()
    {
        Console.WriteLine($"Current balance: {Balance}"); // Allowed since Balance is protected
    }
}



public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public class Employee : Person
{
    public string Position { get; set; }
    
    public Employee(string name, int age, string position) : base(name, age)
    {
        Position = position;
    }
}

public abstract class Animal
{
    public abstract void MakeSound(); // Abstract method that must be implemented
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof Woof!");
    }
}

// Abstração 