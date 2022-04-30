// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка)

Console.Write("Enter the number: ");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);

if (a % 2 == 0)
{
    Console.WriteLine("Your number is even");
}
else
{
    Console.WriteLine("Your number is odd");
}
