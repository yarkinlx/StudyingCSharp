// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Write("Enter the number: ");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);
int start = 1;
while (start <= a)
{
    if (start % 2 == 0)
    {
        Console.Write($"{start}, ");
        start = start + 1;
    }
    else
    {
        start = start + 1;
    }

}