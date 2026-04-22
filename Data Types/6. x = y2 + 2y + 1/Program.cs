/* Write a C# Sharp program to display certain values 
 * of the function x = y2 + 2y + 1 
 * (using integer numbers for y, ranging from -5 to +5). */
for (int y = -5; y <= 5; y++)
    Console.WriteLine($"x = y2 + 2y + 1, when y = {y}, x = {y * 2 + 2 * y + 1}");