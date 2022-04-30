// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.


Console.Write ("Enter the first number: ");
string s_a = Console.ReadLine();
Console.Write ("Enter the second number: ");
string s_b = Console.ReadLine();

int a = int.Parse(s_a);
int b = int.Parse(s_b);

if(a * a == b)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}