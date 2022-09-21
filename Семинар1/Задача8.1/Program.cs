// напишите программу, которая на вход принимает число (N) , а на выходе показывает все четные числа от 1-N

Console.Clear();

Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine() ?? "0");

int number = 2;

while (number <= num)
{
    if (number % 2 == 0) Console.Write(number + ", ");
    number += 2;
}