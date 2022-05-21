// Напишите программу, которая выводит
//случайное трёхзначное число и удаляет вторую цифру
//этого числа.

void Remove()
{
    int RandomNumber = new Random().Next(100, 1000);
    Console.Write("Random number is ");
    Console.WriteLine(RandomNumber);
    Console.Write("Removed the second digit from ");
    Console.WriteLine($"{RandomNumber}, got  {RandomNumber/ 100}{RandomNumber % 10}");
}


Remove();