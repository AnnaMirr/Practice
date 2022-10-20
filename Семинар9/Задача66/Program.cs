// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Рекурсивно

Console.WriteLine("Enter natural number A:");
int numberA = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Enter natural number B:");
int numberB = int.Parse(Console.ReadLine() ?? "0");

void GapNumberSum(int numberA, int numberB, int sum)
{
    if (numberA > numberB)
    {
        Console.WriteLine($"The sum of elements from A to B: {sum}");
        return;
    }
    sum = sum + (numberA++);
    GapNumberSum(numberA, numberB, sum);
}

GapNumberSum(numberA, numberB, 0);