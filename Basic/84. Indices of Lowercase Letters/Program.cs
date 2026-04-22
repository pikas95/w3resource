/*84. Indices of Lowercase Letters

Write a C# Sharp program to get the index number of all lower case letters in a given string.
Sample Output:
Orginal string: Python
Indices of all lower case letters of the said string:
1 2 3 4 5
Orginal string: JavaScript
Indices of all lower case letters of the said string:
1 2 3 5 6 7 8 9*/

Console.WriteLine("Type in a string");
string input = Console.ReadLine();

Console.WriteLine(string.Join(" ", LowerCaseIndices(input)));
int[] LowerCaseIndices(string input)
{
    int[] lowerCaseIndices = new int[input.Length];
    int arrayIndex = 0;

    for (int i = 0; i < input.Length; i++)
        if (char.IsLower(input[i]))
            lowerCaseIndices[arrayIndex++] = i;

    Array.Resize(ref lowerCaseIndices, arrayIndex);
    return lowerCaseIndices;
}