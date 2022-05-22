// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void ThirdDegree(int n)
{
    double[] nums = new double[n];
    int index = 0;

    Console.Write($"{n} -> ");

    while(index < n)
    {
        nums[index] = Math.Pow((index + 1), 3);
        Console.Write($"{nums[index]}, ");
        index++;
    }
    Console.WriteLine();
 
}

ThirdDegree(5);
ThirdDegree(7);
ThirdDegree(9);


