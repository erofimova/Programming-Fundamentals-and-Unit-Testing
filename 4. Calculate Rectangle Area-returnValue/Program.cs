﻿int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int area = CalculateArea(width, length);
Console.WriteLine(area);
static int CalculateArea(int width, int length)
{
    int area = width * length;
    return area;
}