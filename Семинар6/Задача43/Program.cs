﻿// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

Console.Write("Enter k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Point intersection: ({x};{y})");