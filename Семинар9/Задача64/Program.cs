// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

Console.WriteLine("Enter a positive integer from 1: ");
int num = Convert.ToInt32(Console.ReadLine());

void OutputOfNum(int num)
{
    if (num < 0) Console.WriteLine($"{num} not a natural number");
    if (num == 0) return;
    Console.Write("{0,4}", num);
    OutputOfNum (num - 1);
}

OutputOfNum(num);
