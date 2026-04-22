/* 58. Complete Missing Numbers in Range

Write a C# program that accepts a list of integers and 
checks how many integers are needed to complete the range.
Sample Example [1, 3, 4, 7, 9], between 1-9 -> 2, 5, 6, 8 are not present in the list. 
So output will be 4.*/
int[] numbers = new int[5];
int min = int.MaxValue, max = int.MinValue;
Console.WriteLine("Type in 5 numbers");
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    if (numbers[i] < min) min = numbers[i];
    if (numbers[i] > max) max = numbers[i];
}
Console.WriteLine($"Numbers needed to complete the range: {max - min - numbers.Length - 1}");