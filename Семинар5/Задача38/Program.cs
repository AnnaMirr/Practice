//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

double[] numbers = new double[5];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);



void FillArrayRandomNumbers(double[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        // numbers[i] = random.NextDouble() *1000;
        numbers[i] = Convert.ToDouble(random.Next(-100,100)/10.0);
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
