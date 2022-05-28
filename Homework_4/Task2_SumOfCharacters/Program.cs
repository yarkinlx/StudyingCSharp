// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumIn(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

Console.WriteLine(SumIn(5555));
Console.WriteLine(SumIn(99));
Console.WriteLine(SumIn(115));