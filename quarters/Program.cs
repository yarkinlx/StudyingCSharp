//Напишите программу, которая по заданному номеру четверти,
//показывает диапазон возможных координат точек в этой четверти (x и y)


void QuarterCheck()
{
    Console.Write("Enter the quarter number:");
    string s_number = Console.ReadLine();
    int quarter = int.Parse(s_number);
    if(quarter == 1)
    {
        Console.WriteLine("X(0;+∞),Y(0;+∞)");
    }
    if(quarter == 2)
    {
        Console.WriteLine("X(-∞;0),Y(0;+∞)");
    }
    if(quarter == 3)
    {
        Console.WriteLine("X(-∞;0),Y(-∞;0)");
    }
    if(quarter == 4)
    {
        Console.WriteLine("X(0;+∞),Y(-∞;0)");
    }
    else
    {
        Console.WriteLine("enter the valid number (from 1 to 4)");
    }
}



QuarterCheck();
QuarterCheck();
QuarterCheck();
QuarterCheck();