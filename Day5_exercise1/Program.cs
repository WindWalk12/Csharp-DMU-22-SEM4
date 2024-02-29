
List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 30, 24 };

myList.FindAll(i => i % 2 == 0).ForEach(i => Console.WriteLine(i));

Console.WriteLine();

Console.WriteLine(myList.FindLast(i => i > 15));

Console.WriteLine();

Console.WriteLine(myList.FindLastIndex(i => i > 15));