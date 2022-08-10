



Console.WriteLine("Введите номер плоскости");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);


if (a == 1)
{
    Console.WriteLine("X(0; + бесконечность), Y(0; + бесконечность)");
}
else if (a == 2 )
{
    Console.WriteLine("X(- бесконечность;0), Y(0; + бесконечность)");
}
else if (a == 3)
{
    Console.WriteLine("X(- бесконечность;0), Y(- бесконечность;0)");
}
else if (a == 4)
{
    Console.WriteLine("X(0; + бесконечность),Y(- бесконечность;0) ");
}
else
{
    Console.WriteLine("Такого номера плоскости не существует");
}