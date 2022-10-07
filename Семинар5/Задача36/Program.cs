// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

Console.WriteLine("Enter size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 == 1)
    sum += numbers[i];
}
Console.WriteLine($"Odd position sum is: {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers [i] = random.Next(10,100);
    }
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

