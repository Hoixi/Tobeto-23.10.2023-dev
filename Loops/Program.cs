using System.Runtime.CompilerServices;

static void ForLoop()
{
    for (int i = 100; i >= 0; i = i - 2)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished!");
}

static void WhileLoop()
{
    int number = 100;
    while (number >= 0)
    {
        Console.WriteLine(number);
        number--;
    }
    Console.WriteLine("Now number is {0}", number);
}

static void DoWhileLoop()
{
    int number = 10;
    do
    {
        Console.WriteLine(number);
        number--;
    } while (number >= 11);
}

static void ForEachLoop()
{
    string[] students = new string[3] { "Engin", "Demir", "Salih" };

    foreach (var stundent in students)
    {
        Console.WriteLine(stundent);
    }
}

static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i < number; i++) {
        if (number % i == 0)
        { 
            result = false;
            i = number;
        }
    }

    return result;
}

if (IsPrimeNumber(10))
{
    Console.WriteLine("This is a prime number");
}

else
{
    Console.WriteLine("This is not a prime number");
}