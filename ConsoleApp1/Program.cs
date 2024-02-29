// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using MyLibraryFis;

Console.WriteLine("Hello, World!");

Person p = new Person("Emil", "Ustabil");
Console.WriteLine(p);
p.FirstName = "Peter";
Console.WriteLine(p);

Console.WriteLine();

Console.WriteLine("Hvilket dyr er fido?");
var species = Console.ReadLine();
var fido = new Animal(species);
Console.WriteLine("Er fido en hund? " + fido.IsDog());

Console.WriteLine();
Console.WriteLine("Liste");

var liste = new MyList<int>();
liste.AddNumber(1);
liste.AddNumber(54);
liste.AddNumber(3);
liste.AddNumber(4);
liste.AddNumber(5);
liste.PrintNumbers();

Console.WriteLine();
Console.WriteLine("Liste2");

var liste2 = new MyList<int>();
liste2.AddRandom();
liste2.PrintNumbers();