/* 5. Write a C# Sharp program that takes the radius of a circle as input and calculates the perimeter and area of the circle.

Test Data
Input the radius of the circle :
12
Expected Output :
Perimeter of Circle : 75.36 */

Console.Write("Input the radius of the circle: ");
double radius = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Perimeter of circle: {2 * Math.PI * radius:0.00}");
Console.WriteLine($"Area of circle: {Math.PI * Math.Pow(radius, 2):0.00}");