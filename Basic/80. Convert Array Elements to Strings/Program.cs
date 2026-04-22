/*80. Convert Array Elements to Strings

Write a C# Sharp program to convert all the values of a given array of mixed values to string values.
Sample Output:
Printing original array elements and their types:
Value-> 25 :: Type-> System.Int32
Value-> Anna :: Type-> System.String
Value-> False :: Type-> System.Boolean
Value-> 4/15/2021 10:37:47 AM :: Type-> System.DateTime
Value-> 112.22 :: Type-> System.Double
Printing array elements and their types:
Value-> 25 :: Type-> System.String
Value-> Anna :: Type-> System.String
Value-> False :: Type-> System.String
Value-> 4/15/2021 10:37:47 AM :: Type-> System.String
Value-> 112.22 :: Type-> System.String*/
int number = 25;
string name = "Anna";
bool boolean = false;
DateTime time = DateTime.Now;
double pointNumber = 112.22;
string[] values = new string[5];
values[0] = Convert.ToString(number);
values[1] = Convert.ToString(name);
values[2] = Convert.ToString(boolean);
values[3] = Convert.ToString(time);
values[4] = Convert.ToString(pointNumber);
for (int i = 0; i < values.Length; i++)
    Console.WriteLine(values[i]);