// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Enter the first number: ");
string s_a = Console.ReadLine();
Console.Write("Enter the second number: ");
string s_b = Console.ReadLine();
Console.Write("Enter the third number: ");
string s_c = Console.ReadLine();

int a = int.Parse(s_a);
int b = int.Parse(s_b);
int c = int.Parse(s_c);

int Max = a;

if (b > Max) Max = b;
if (c > Max) Max = c;

Console.Write("Maximum is ");
Console.WriteLine(Max);