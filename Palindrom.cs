//Console.Clear();

int newNumber = 0;

Console.Write("Please enter the number you want to check: ");
int number = int.Parse(Console.ReadLine()!);

int startNumber = number;

if (number < 10)
{
    Console.WriteLine("Your number is a Palindrom");
}
else
{
    do
    {
        newNumber = newNumber * 10 + number % 10;
        number /= 10;

        Console.WriteLine(newNumber);
    } while (number != 0);
    if (newNumber == startNumber)
    {
        Console.WriteLine("Your number is a Palindrom");
    }
    else 
    {
        Console.WriteLine("Your number isn't a Palindrom");
    }
}
