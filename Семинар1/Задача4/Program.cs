// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();

Console.WriteLine("Enter number a: ");
string input = Console.ReadLine();
int numbermax = int.Parse(input);
int a = numbermax;


Console.WriteLine("Enter number b: ");
string input1 = Console.ReadLine();
int number2 = int.Parse(input1);
int b = number2;

Console.WriteLine("Enter number с: ");
string input2 = Console.ReadLine();
int number3 = int.Parse(input2);
int с = number3;


numbermax = numbermax > number2 ? numbermax = numbermax : numbermax = number2;
numbermax = numbermax > number3 ? numbermax = numbermax : numbermax = number3;

Console.WriteLine(("Maximum number is ") + (numbermax));