



void FillArray(int[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(0, 100);  // можно оставить пустые скобки или поменять диапозон
    }

}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(" " + numbers[i]);
    }
}

void Zadacha29()
{
    int[] numbers = new int[8];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("---> " + $"[{String.Join(",", numbers)}]");

}

Zadacha29();
