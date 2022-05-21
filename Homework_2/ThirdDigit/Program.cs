//Напишите программу, которая выводит третью
//цифру заданного числа или сообщает, что третьей цифры
//нет.

void ThirdDigit()
{
    Console.Write("Enter the number: ");
    string s_number = Console.ReadLine();
    int number = int.Parse(s_number);
    if(number>99)
    {
        Console.WriteLine(number.ToString()[2]);
    }
    else
    {
        Console.WriteLine("There is no the third digit");
    }
}

ThirdDigit();