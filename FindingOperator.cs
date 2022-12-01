//Console.Clear();

const string PLUS = "plus";
const string MINUS = "minus";
const string MULTIPLY = "multiply";
const string DIVIDE = "divide";
const string MODULU = "modulu";
const string EXPONENTIATION = "exponent";

Console.Write("Please enter your first number: ");
double firstNumber = double.Parse(Console.ReadLine()!);
Console.Write("Please enter your second number: ");
double secondNumber = double.Parse(Console.ReadLine()!);
Console.Write("Please enter your result: ");
double result = double.Parse(Console.ReadLine()!);

if (firstNumber + secondNumber == result) {Console.WriteLine(PLUS);}
else if (firstNumber- secondNumber == result) {Console.WriteLine(MINUS);}
else if (secondNumber - firstNumber == result) {Console.WriteLine(MINUS);}
else if (firstNumber * secondNumber == result) {Console.WriteLine(MULTIPLY);}
else if (firstNumber / secondNumber == result) {Console.WriteLine(DIVIDE);}
else if (secondNumber / firstNumber == result) {Console.WriteLine(DIVIDE);}
else if (Math.Pow(secondNumber, firstNumber) == result) {Console.WriteLine(EXPONENTIATION);}
else if (Math.Pow(firstNumber, secondNumber) == result) {Console.WriteLine(EXPONENTIATION);}
else if (firstNumber % secondNumber == result) {Console.WriteLine(MODULU);}
else if (secondNumber % firstNumber == result) {Console.WriteLine(MODULU);}