/* 11. Write a C# Sharp program that takes a decimal number as input and displays its equivalent in binary form.
Test Data:
Number to convert (or "end")? 25
Expected Output:
Binary: 11001 */

Console.Write("Number to convert (or \"end\")? ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Binary form of {number} is: {ConvertToBinary(number)}.");

int ConvertToBinary(int number)
{
    int binary = 0, digitPosition = 1;
    while (number > 0)
    {
        binary += number % 2 * digitPosition;
        digitPosition *= 10;
        number /= 2;
    }
    return binary;
}