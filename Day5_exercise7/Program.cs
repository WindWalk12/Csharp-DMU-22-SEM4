using Day5_exercise7;

string csv = @"data1.csv";

List<Person> peopleList = Person.ReadCSVFile(csv);

var peopleListSortedScore = from person in peopleList
                            orderby person.Score
                            select person;
foreach (var person in peopleListSortedScore)
{
    Console.WriteLine(person);
}

Console.WriteLine();

var peopleListSortedAge = from person in peopleList
                            orderby person.Age
                            select person;
foreach (var person in peopleListSortedAge)
{
    Console.WriteLine(person);
}

Console.WriteLine();

var peopleListSortedAgeDesc = from person in peopleList
                          orderby person.Age descending
                          select person;
foreach (var person in peopleListSortedAgeDesc)
{
    Console.WriteLine(person);
}