Console.WriteLine("Enter the number of rows: ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);


void FillArrayRandomNumbers(double[,] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            // numbers[i] = random.NextDouble() *1000;
            numbers[i, j] = Convert.ToDouble(random.Next(-100, 100) / 10.0);
        }
    }
}

void PrintArray(double[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
     }
}