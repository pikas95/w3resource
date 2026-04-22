/*20. Absolute Difference or Double It

Write a C# program to get the absolute value of the difference 
between two given numbers. Return double the absolute value of 
the difference if the first number is greater than the second number.*/
Console.WriteLine("Enter two numbers");
double n1 = Convert.ToDouble(Console.ReadLine());
double n2 = Convert.ToDouble(Console.ReadLine());
double absoluteDifference = n1 - n2 > 0 ? n1 - n2 : -(n1 - n2);
Console.WriteLine($"\nAbsolute difference: {absoluteDifference}");