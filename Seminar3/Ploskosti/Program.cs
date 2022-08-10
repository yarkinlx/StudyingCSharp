


Console.WriteLine("Введите X");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);
Console.WriteLine("Введите Y");
string s_b = Console.ReadLine();
int b = int.Parse(s_b);

if (a > 0 & b > 0)
{
    Console.WriteLine("Точка находится в плоскости 1");
}
else if (a > 0 & b < 0)
{
    Console.WriteLine("Точка находится в плоскости 4");
}
else if (a < 0 & b < 0)
{
    Console.WriteLine("Точка находится в плоскости 3");
}
else
{
    Console.WriteLine("Точка находится в плоскости 2");
}