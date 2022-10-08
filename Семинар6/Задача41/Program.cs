// Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

Console.WriteLine("Enter the size for number: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [size];
ArrayFromEnter(numbers);
PrintArrayFromEnter(numbers);

int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    count++;
}
Console.WriteLine($"Number of pozitiv number is: {count}");

void ArrayFromEnter(int[] numbers)
{
    Console.Write("Enter number: ");
    for (int i = 0; i < size; i++)
    {
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}


void PrintArrayFromEnter(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++ )
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}