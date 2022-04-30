Console.Write("Enter your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "alex")
{
    Console.WriteLine("Hi Alex, you're awesome!");
}
else
{
    Console.Write("Hi ");
    Console.WriteLine(username);
}