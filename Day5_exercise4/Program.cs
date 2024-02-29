using Day5_exercise4;

string csv = @"data1.csv";

List<Person> peopleList = Person.ReadCSVFile(csv);


Console.WriteLine(peopleList.FindIndex(x => x.Score == 3).ToString());
Console.WriteLine();

Console.WriteLine(peopleList.FindIndex(x => x.Score == 3 && x.Age < 10).ToString());
Console.WriteLine();

Console.WriteLine(peopleList.FindAll(x => x.Score == 3 && x.Age < 10).Count());
Console.WriteLine();

Console.WriteLine(peopleList.FindIndex(x => x.Score == 3 && x.Age < 8).ToString());