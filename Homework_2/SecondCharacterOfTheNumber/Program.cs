// Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.

int SecondDigit(int number)
{
    return number / 10 % 10;
}

Console.Write("Enter a three digit number: ");
string s_number = Console.ReadLine();
int number = int.Parse(s_number);

Console.WriteLine(SecondDigit(number));
