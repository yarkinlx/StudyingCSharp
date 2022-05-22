﻿// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

double Distance(int x1, int y1, int x2, int y2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 4);
}

Console.WriteLine(Distance(3, 6, 2, 1));
Console.WriteLine(Distance(7, -5, 1, -1));