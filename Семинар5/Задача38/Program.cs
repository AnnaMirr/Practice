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
        numbers[i] = random.NextDouble();
    }
}

void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}