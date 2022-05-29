// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}


void EvenCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 ==0)
        {
            count++;
        }
    }
    Console.WriteLine($"the quantity of even numbers is = {count} ");
}

int[] arr_1 = CreateArray(6);
Print(arr_1);
EvenCount (arr_1);
int[] arr_2 = CreateArray(6);
Print(arr_2);
EvenCount (arr_2);