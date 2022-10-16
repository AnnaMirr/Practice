// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

double[,] a = new double[3, 5];

Random random = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        a[i, j] = random.NextDouble() * 100 -9;
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}