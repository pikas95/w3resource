/* 2. Write a C# Sharp program that takes a number and a width also a number. It then displays a triangle of that width using that number.
Test Data
Enter a number: 6
Enter the desired width: 6
Expected Output :

666666                                                      
66666                                                           
6666                                                                  
666                                                        
66                                                                  
6 */

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the desired width: ");
int width = Convert.ToInt32(Console.ReadLine()); // width and height

for (int row = width; row > 0; row--) // starts at the end => index can be used as column width
{
    for (int column = 0; column < row; j++)
        Console.Write(number);
    Console.WriteLine();
}