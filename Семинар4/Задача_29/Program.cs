



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
        Console.WriteLine("[{0}]", string.Join(", ", numbers));
    }
}


void Zadacha29()
{
    int[] numbers = new int[];
    FillArray(numbers);
    PrintArray(numbers);
}


Zadacha29();
