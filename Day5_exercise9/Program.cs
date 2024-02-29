using Day5_exercise9;

string csv = @"data1.csv";

List<Person> peopleList = Person.ReadCSVFile(csv);

peopleList.SetAccepted(p => p.Score >= 6 && p.Age <= 40);

peopleList.ForEach(p => Console.WriteLine(p));

Console.WriteLine();

peopleList.Reset();

peopleList.ForEach(p => Console.WriteLine(p));