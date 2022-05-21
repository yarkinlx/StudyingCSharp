// Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.

void WeekendCheck()
{
    Console.Write("Enter the number: ");
    string s_number = Console.ReadLine();
    int number = int.Parse(s_number);
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}

WeekendCheck();