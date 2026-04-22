/* 7. Write a C# Sharp program that takes distance and time as input and displays speed in kilometres per hour and miles per hour.
Test Data:
Input distance(metres): 50000
Input timeSec(hour): 1
Input timeSec(minutes): 35
Input timeSec(seconds): 56
Expected Output:
Your speed in metres/sec is 8.686588
Your speed in km/h is 31.27172
Your speed in miles/h is 19.4355 */

Console.Write("Input distance(metres): ");
int distance = Convert.ToInt32(Console.ReadLine());

Console.Write("Input hour: ");
int timeSec = Convert.ToInt32(Console.ReadLine()) * 3600;

Console.Write("Input minutes: ");
timeSec += Convert.ToInt32(Console.ReadLine()) * 60;

Console.Write("Input seconds: ");
timeSec += Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your speed in metres/sec is " + (float)distance / timeSec);
Console.WriteLine("Your speed in km/h is " + (distance * 0.001f) / (timeSec / 3600.0f));
Console.WriteLine("Your speed in miles/h is " + (distance * 0.001f) / (timeSec / 3600.0f) / 1.609f);
