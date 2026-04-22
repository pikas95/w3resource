/*Write a C# program to create a new string from a given string 
 * where the first and last characters change their positions.
Test Data:
w3resource
Python
Sample Output:
e3resourcw
nythoP
x*/
string input = "w3resource";
string swaped = input[^1] + input[1..^2] + input[0];
Console.WriteLine(swaped);