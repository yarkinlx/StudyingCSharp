// Напишите программу, которая на вход принимает одно число(N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Enter the number: ");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);
int b = -a;


while (b <= a)
{
    Console.Write($"{b}, ");
    b = b + 1;
}
