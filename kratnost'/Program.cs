// 3. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

void Kratnost(int a, int b)
{
    if (b % a == 0)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        int c = b % a;
        Console.WriteLine(c);
    }
}

Console.WriteLine("Введите первое число");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);
Console.WriteLine("Введите второе число");
string s_b = Console.ReadLine();
int b = int.Parse(s_b);

Kratnost(a,b);

