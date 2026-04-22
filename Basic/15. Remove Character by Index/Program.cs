/* 15. Remove Character by Index

Write a C# program that removes a specified character from a non-empty string using the index of a character.
Test Data:
w3resource
Sample Output:
wresource
w3resourc
3resource*/
Console.WriteLine("Enter a string:");
string input = Console.ReadLine();
if (input != "")
{
    Console.WriteLine("Output:");
    for (int i = 0; i < input.Length; i++)
        Console.WriteLine(input.Remove(i, 1));
}
else Console.WriteLine("String is empty...");