// Напишите программу, которая задаёт массив из 8 элементов случайными числами
// и выводит их на экран. 
// Оформите заполнение массива и вывод в виде функции 

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while(index< length)
    {
        array[index]= new Random().Next(0,9);
        index++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i= 0; i< count; i++)
    {
        Console.Write($"{array[i]  }");
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);