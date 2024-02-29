using Day5_exercise3;

string csv = @"data1.csv";

List<Person> peopleList = Person.ReadCSVFile(csv);

peopleList.FindAll(x => x.Score < 2).ForEach(x => Console.WriteLine(x));
Console.WriteLine();

peopleList.FindAll(x => x.Score % 2 == 0).ForEach(x => Console.WriteLine(x));
Console.WriteLine();

peopleList.FindAll(x => x.Score % 2 == 0 && x.Weight > 60).ForEach(x => Console.WriteLine(x));
Console.WriteLine();

peopleList.FindAll(x => x.Weight % 3 == 0).ForEach(x => Console.WriteLine(x));