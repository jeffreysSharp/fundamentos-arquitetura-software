/////////////////////////////////////////////////////
///Herança
using Fundamentals.Architecture.OOP.Pillars.Inheritance;


var employee = new Employee
{
    Name = "Jeferson Almeida",
    Age = 43,
    Position = "Desenvolvedor Full Stack",
    Salary = 10000,
};

employee.Introduce();
employee.Work();




/////////////////////////////////////////////////////
///Estado e comportamento
//using Fundamentals.Architecture.OOP.ClassVsObjects;

//// Criando um objeto da classe House
//House myHouse = new House("Azul", 3, 120.5);

//// Exibindo informações
//myHouse.DisplayInfo();


//// Abrindo e fechando
//myHouse.OpenDoor();
//myHouse.CloseDoor();