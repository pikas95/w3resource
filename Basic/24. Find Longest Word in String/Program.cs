/*24. Find Longest Word in String

Write a C# program to find the longest word in a string.
Test Data: Write a C# Sharp Program to display the following pattern using the alphabet.
Sample Output:
following*/
Console.WriteLine("Enter a string:");
string input = Console.ReadLine();
string[] words = input.Split(" ");
string longestWord = "";
foreach (string word in words)
    if (longestWord.Length < word.Length)
        longestWord = word;
Console.WriteLine(longestWord);