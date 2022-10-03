// Вввод строк и чисел для преобразования в двоичную матрицу 

int[,] CreateArray(int row, int coloumn)
{
    int[,] array = new int [row, coloumn];
    return array;
}
 
void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i,j] = new Random().Next(0, 2);
        }
    }
}
 
void PrintArray(int[,] arr)
{
    for (int rows = 0; rows < arr.GetLength(0); rows++)
    {
        for(int coloumns = 0; coloumns < arr.GetLength(1); coloumns++)
        {
            Console.Write($"| {arr[rows, coloumns]} |");
        }
    Console.WriteLine();
    }
}
 
Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine()!);
 
Console.Write("Введите число столбцов: ");
int coloumn = int.Parse(Console.ReadLine()!);
 
int[,] ar = CreateArray(row, coloumn);
FillArray(ar);
PrintArray(ar);
 
