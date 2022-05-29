// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

int[] CreateArray(int size)
{

    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void SumInOdd(int[] arr)
{
    int Sum = arr[0];
    for (int i = 2; i < arr.Length; i = i + 2)
    {
        Sum = Sum + arr[i];
    }
    Console.WriteLine($"the sum of numbers in odd positions is  = {Sum} ");
}

int[] arr_1 = CreateArray(7);
Print(arr_1);
SumInOdd(arr_1);
int[] arr_2 = CreateArray(10);
Print(arr_2);
SumInOdd(arr_2);
