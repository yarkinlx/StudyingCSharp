// Задача 2: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

//Формула вычисления расстояния между двумя точками A(xa, ya, za) и B(xb, yb, zb) в пространстве:
//AB = √(xb - xa)^2 + (yb - ya)^2 + (zb - za)^2

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 4);

}

Console.WriteLine(Distance(3, 6, 8, 2, 1, -7));
Console.WriteLine(Distance(7, -5, 0, 1, -1, 9));