Console.Write($"How much numbers will be put: ");
int q = int.Parse(Console.ReadLine());
int[] arrayNumbers = new int[q];



void HowMuch(int q)
{
    for (int i = 0; i < q; i++)
    {
        Console.Write($"Enter the next number: ");
        arrayNumbers[i] = int.Parse(Console.ReadLine());
    }
}

int PositiveCheck(int[] arrayNum)
{
    int count = 0;
    for (int i = 0; i < arrayNum.Length; i++)
    {
        if (arrayNum[i] > 0)
        {
            count += 1;
        } 
    }
    return count;
}



HowMuch(q);

Console.WriteLine($"The number of digits above zero is {PositiveCheck(arrayNumbers)}");