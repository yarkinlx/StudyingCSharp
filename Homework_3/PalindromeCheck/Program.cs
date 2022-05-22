// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void PalindromeCheck()
{
    Console.WriteLine("Enter a five digit number: ");
    string number = Console.ReadLine();
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Yes, your number is palindrome");
    }
    else
    {
        Console.WriteLine("No, your number is not palindrome");
    }
}

PalindromeCheck();
PalindromeCheck();
PalindromeCheck();
