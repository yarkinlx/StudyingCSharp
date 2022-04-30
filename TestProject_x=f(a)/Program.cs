// Напишите программу вычисления функции: x = f(a)

Console.Write ("Enter the number: ");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);
int x = 4 * a * a + 17 * a + 8;
Console.WriteLine(x);