/* 1. Write a C# Sharp program that takes three letters and displays them in reverse order.
Test Data
Enter letter: b
Enter letter: a
Enter letter: t
Expected Output :
t a b */

char[] letters = new char[3];
for (int i = 0; i < 3; i++)
{
    Console.Write("Enter letter: ");
    letters[i] = Convert.ToChar(Console.ReadLine());
}
Console.WriteLine(string.Join(" ", letters.Reverse()));

/* OR
char letter1, letter2, letter3;

Console.Write("Enter letter: ");
letter1 = Convert.ToChar(Console.ReadLine());

Console.Write("Enter letter: ");
letter2 = Convert.ToChar(Console.ReadLine());

Console.Write("Enter letter: ");
letter3 = Convert.ToChar(Console.ReadLine());

Console.WriteLine($"{letter3} {letter2} {letter1}"); */