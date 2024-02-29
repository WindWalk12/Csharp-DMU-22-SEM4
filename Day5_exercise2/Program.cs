
List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 30, 24 };

var res = myList.Where(i => i % 2 == 0);
foreach (var item in res)
{
    Console.WriteLine(item);
}

Console.WriteLine();

var resCifre = myList.Where(i => i.ToString().Length == 2);
foreach (var item in resCifre)
{
    Console.WriteLine(item);
}

Console.WriteLine();

var resCifreSorted = resCifre.OrderBy(i => i);
foreach (var item in resCifreSorted)
{
    Console.WriteLine(item);
}

Console.WriteLine();
Console.WriteLine("Query expressions");
Console.WriteLine();

var resExpression = from i in myList
                    where i % 2 == 0
                    select i;
foreach (var item in resExpression)
{
    Console.WriteLine(item);
}

Console.WriteLine();

var resCifreExpression = from i in myList
                    where i.ToString().Length == 2
                    select i;
foreach (var item in resCifreExpression)
{
    Console.WriteLine(item);
}

Console.WriteLine();

var resCifreSortedExpression = from i in myList
                               where i.ToString().Length == 2
                               orderby i
                               select i;
foreach (var item in resCifreSortedExpression)
{
    Console.WriteLine(item);
}