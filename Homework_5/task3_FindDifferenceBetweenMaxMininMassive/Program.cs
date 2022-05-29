// Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.


void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

double[] CreateArray(int size)
{

    double[] arr = new double[size];
    Random n_new = new Random();
    for (int i = 1; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble() * (10 + 12) - 10, 2);
    }
    return arr;
}

void Difference (double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    double difference = 0;
    for (int i =0; i<arr.Length;i++)
    {
        if(arr[i]>max)
        {
            max = arr[i];
        }
        else if (arr[i]<min)
        {
            min= arr[i];
        }
    difference = Math.Round((max - min), 2);
    }
    Console.Write($"Max is {max}, Min is {min}. ");
    Console.WriteLine($"Difference is {difference} ");
}

double[] arr_1 = CreateArray(7);
Print(arr_1);
Difference(arr_1);
double[] arr_2 = CreateArray(16);
Print(arr_2);
Difference(arr_2);