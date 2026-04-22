/* 3. Write a C# Sharp program that takes userid and password as input (string type). 
 * After 3 unsuccessful attempts, the user will be rejected. */
string userid = "Alicja";
string password = "Alexisbest";
int attempt = 0;
do
{
    Console.Write("User, type in your userid: ");
    string useridInput = Console.ReadLine();

    Console.Write("User, type in your password: ");
    string passwordInput = Console.ReadLine();

    if (useridInput == userid)
    {
        if (passwordInput == password)
        {
            attempt = 0;
            break;
        }
        else
        {
            attempt++;
            Console.WriteLine($"Wrong password. {3 - attempt} attempts remaining.\n");
            continue;
        }
    }
    attempt++;
    Console.WriteLine($"Wrong usedid or/and password. {3 - attempt} attempts remaining.\n");
}
while (attempt < 3);
if (attempt < 3) Console.WriteLine("Log in successful");
else Console.WriteLine("Try 1 hour later.");