/* 10. Write a C# Sharp program that takes two numbers as input 
 * and returns true or false when both numbers are even or odd. */

Console.Write("Write first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Write second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Both numbers {0} even or odd.", (number1 + number2) % 2 == 0 ? "are" : "are not");