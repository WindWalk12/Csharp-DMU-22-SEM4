int[] numbers = { 34, 8, 56, 31, 79, 150, 88, 7, 200, 47, 88, 20 };

var numbersTwoDigitSorted = from i in numbers
                            where i.ToString().Length == 2
                            orderby i
                            select i;

foreach (var i in numbersTwoDigitSorted)
{
    Console.WriteLine(i);
}

Console.WriteLine();

var numbersTwoDigitSortedDesc = from i in numbers
                            where i.ToString().Length == 2
                            orderby i descending
                            select i;

foreach (var i in numbersTwoDigitSortedDesc)
{
    Console.WriteLine(i);
}

Console.WriteLine();

var numbersTwoDigitSortedAsString = from i in numbers
                            where i.ToString().Length == 2
                            orderby i
                            select i.ToString();

foreach (var i in numbersTwoDigitSortedAsString)
{
    Console.WriteLine(i);
}

Console.WriteLine();

var numbersTwoDigitSortedDescEvenOdd = from i in numbers
                                where i.ToString().Length == 2
                                orderby i descending
                                select i % 2 == 0 ? i.ToString() + " Even" : i.ToString() + " Odd";

foreach (var i in numbersTwoDigitSortedDescEvenOdd)
{
    Console.WriteLine(i);
}