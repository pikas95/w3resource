/* 9. Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
Test Data:
Input a symbol: a
Expected Output:
It's a lowercase vowel. */

Console.Write("Input a symbol: ");
char symbol = Convert.ToChar(Console.ReadLine());

Console.WriteLine(CheckSymbol(symbol));

string CheckSymbol(char symbol)
{
    if ("aeiou".Contains(symbol))
        return "It's a lowercase vowel.";
    if ("AEIOU".Contains(symbol))
        return "It's a uppercase vowel.";
    if (char.IsDigit(symbol))
        return "It's a digit.";
    return "It's some other symbol.";
}