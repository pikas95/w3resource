/*17. Add First Character to Front and Back

Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back.
Sample Output:
Input a string : The quick brown fox jumps over the lazy dog.
TThe quick brown fox jumps over the lazy dog.T*/
Console.WriteLine("Enter a string");
string input = Console.ReadLine();
string output = input[0] + input + input[0];
Console.WriteLine(output);