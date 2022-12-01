Console.Clear();

Console.Write("Please enter your higher barrier: ");
int higherBarrier = int.Parse(Console.ReadLine()!);
Console.Write("Please enter your Fizz number: ");
int Fizz = int.Parse(Console.ReadLine()!);
Console.Write("Please enter your Buzz number: ");
int Buzz = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= 100; i++)
{
    if (i % Fizz == 0 && i % Buzz == 0)
    {
        Console.Write("FizzBuzz");
    }
    else if (i % Fizz == 0)
    {
        Console.Write("Fizz, ");
    }
    else if (i % Buzz == 0)
    {
        Console.Write("Buzz, ");
    }
    else 
    {
        Console.Write($"{i}, ");
    }
}