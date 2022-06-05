﻿int[,] GenArray()
{
    Console.Write("Enter m: ");
    int m = int.Parse(Console.ReadLine ());
    Console.Write("Enter n: ");
    int n = int.Parse(Console.ReadLine ());
    int[,] arr = new int[m, n];
    Random rand = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rand.Next(1, 11);
        }

    }
    return arr;
}

void PrintArray(int[,] prarr)
{
    for (int i = 0; i < prarr.GetLength(0); i++)
    {
        for (int j = 0; j < prarr.GetLength(1); j++)
        {
            Console.Write(prarr[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void AverageElemColumnArray(int[,] arr)
{
    int n = arr.GetLength(0);
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }
        Console.Write(sum / n + "\t");
    }
}

int[,] array = GenArray();
PrintArray(array);
Console.WriteLine();
AverageElemColumnArray(array);