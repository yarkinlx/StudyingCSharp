// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Enter the number a: ");
string s_a = Console.ReadLine();
Console.Write("Enter the number b: ");
string s_b = Console.ReadLine();

double a = double.Parse(s_a);
double b = double.Parse(s_b);

if (a > b)
{
    Console.WriteLine("a is max, b is min");
}
else
{
    Console.WriteLine("a is min, b is max");
}
