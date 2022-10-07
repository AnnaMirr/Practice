//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

double[] numbers = new double[5];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
    {
        max = numbers[z];
    }
    if (numbers[z] < min)
    {
        min = numbers[z];
    }
}
Console.WriteLine($"Max:{max}, Min: {min}");
Console.WriteLine($"The difference between the max and min numbers: {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        // numbers[i] = random.NextDouble() *1000;
        numbers[i] = Convert.ToDouble(random.Next(-100, 100) / 10.0);
    }
}

void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(Math.Round(numbers[i], 2, MidpointRounding.AwayFromZero) + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
