using System.Collections.Generic;

Console.Write("Write a number: ");
int input = int.Parse(Console.ReadLine());

while (input != 0)
{
    fib(input);
    //calc_fib(input);
    Console.WriteLine("Write a number: ");
    input = int.Parse(Console.ReadLine());
}

static void fib(int highestNumber)
{
    int a = 0, b = 1;
    Console.Write(a + " " + b + " ");

    for (int i = 2; i < highestNumber; i++)
    {
        int c = a + b;
        Console.Write(c + " ");
        a = b;
        b = c;
    }
}

// recursive

static void calc_fib(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write(rec_fib(i) + " ");
    }
}

static int rec_fib(int n)
{
    if (n <= 1)
        return n;
    return rec_fib(n - 1) + rec_fib(n - 2);
}