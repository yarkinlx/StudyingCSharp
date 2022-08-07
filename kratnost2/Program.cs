// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и
// 23.


void KratnostCheck(int a)
{
    if (a % 7 == 0 & a % 23 == 0)
    {
        Console.WriteLine("Число кратно и 7 и 23");
        
    }
    
    else if (a % 7 == 0)
    {
        Console.WriteLine("Число кратно только 7");
       
        
    }
    
    else if (a % 23 == 0)
    {
        Console.WriteLine("Число кратно только 23");
        
    }
    
    else
    {
        Console.WriteLine("Число не кратно ни 7, ни 23");
        
    }

}


Console.WriteLine("Enter the number");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);

KratnostCheck(a);