Random random = new Random();

List<int> numbers = new List<int>();

for (int i = 0; i < 100; i++)
{
    numbers.Add(random.Next(100) + 1);
}


int oddNumbers = numbers.Where(i => i % 2 == 1).Count();
Console.WriteLine(oddNumbers);

Console.WriteLine();

int distinctNumbers = numbers.Distinct().Count();
Console.WriteLine(distinctNumbers);

Console.WriteLine();

var threeFirstOdd = numbers.Where(i => i % 2 == 1).Take(3);
foreach (int i in threeFirstOdd)
{
    Console.WriteLine(i);
}

Console.WriteLine();

var distinctOdd = numbers.Where(i => i % 2 == 1).Distinct();
foreach (int i in distinctOdd)
{
    Console.WriteLine(i);
}