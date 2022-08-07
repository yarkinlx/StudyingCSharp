
int MaxCharacter(int a)
{
    int b = a / 10;
    int c = a % 10;

    if (b > c)
    {
        return b;
    }
    else
    {
        return c;
    }


}



int a = new Random().Next(10, 99);
Console.WriteLine(a);
Console.WriteLine(MaxCharacter(a));

