// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

Console.Write("Enter coordinates X for A:");
double xa = double.Parse(Console.ReadLine()!);
Console.Write("Enter coordinates Y for A:");
double ya = double.Parse(Console.ReadLine()!);
Console.Write("Enter coordinates Z for A:");
double za = double.Parse(Console.ReadLine()!);

Console.Write("Enter coordinates X for B:");
double xb = double.Parse(Console.ReadLine()!);
Console.Write("Enter coordinates Y for B:");
double yb = double.Parse(Console.ReadLine()!);
Console.Write("Enter coordinates Z for B:");
double zb = double.Parse(Console.ReadLine()!);

double dot = Math.Sqrt(Math.Pow(xa-xb, 2)+Math.Pow(ya-yb, 2)+Math.Pow(za-zb,2));
Console.Write(dot.ToString("0.00"));

