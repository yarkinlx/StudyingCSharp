// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int Degree(int num, int degree)
{
    int result = 1;

    for (int i = 1; i <= degree; i++)
    {
        result = result * num;
    }
    return result;
}
Console.WriteLine(Degree(2, 4));
Console.WriteLine(Degree(4, 4));
Console.WriteLine(Degree(5, 2));