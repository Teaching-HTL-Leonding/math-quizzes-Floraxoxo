Console.Write("Please enter your first number [positive number starting with 1]: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Please enter your second number [positive number starting with 1]: ");
int number1 = int.Parse(Console.ReadLine()!);

int length = 0;
int length1 = 0;

while (number != 1 && number > 0)
{   
    length++;
    if (number % 2 == 0)
    {
        number /= 2;
    }
    else
    {
        number = 3 * number + 1;
    }
}

while (number1 != 1 && number1 > 0)
{
    length1++;
    if (number1 % 2 == 0)
    {
        number1 /= 2;
    }
    else
    {
        number1 = 3 * number1 + 1;
    }
}

if (length > length1)
{
    Console.Write("The Hailstone sequence from your first number is longer");
}
else if (length > length1)
{
    Console.Write("The Hailstone sequence from your second number is longer");
}
else 
{
    Console.Write("Your sequences are equal");
}