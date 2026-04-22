/* 4. Write a C# Sharp program that takes two numbers as input 
 * and performs an operation (+,-,*,x,/) on them
 * and displays the result of that operation. */
Console.Write("Input first number: ");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input operation (+ - * /): ");
char operation = Convert.ToChar(Console.ReadLine());

Console.Write("Input second number: ");
double number2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"{number1} {operation} {number2} = " +
                  $"{PerformOperation(number1, operation, number2)} ");

double PerformOperation(double number1, char operation, double number2)
{
    if (operation == '+') return number1 + number2;
    if (operation == '-') return number1 - number2;
    if (operation == '*') return number1 * number2;
    return number1 / number2;
}