/* 8. Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere.
Test Data:
Radius: 2
Expected Output:
50.26548
33.51032 */

Console.Write("Radius: ");
double radius = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Sphere volume: {(4.0 / 3) * Math.PI * Math.Pow(radius, 3):0.00000}");
Console.WriteLine($"Sphere surface: {4.0 * Math.PI * Math.Pow(radius, 2):0.00000}");