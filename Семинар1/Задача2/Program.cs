// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.WriteLine("Enter number a: ");
string input = Console.ReadLine();
int number = int.Parse(input);
int a = number;


Console.WriteLine("Enter number b: ");
string input1 = Console.ReadLine();
int number2 = int.Parse(input1);
int b = number2;

if (a > b)
    Console.WriteLine("a is bigger then b");

else
    Console.WriteLine("b is bigger then a");





