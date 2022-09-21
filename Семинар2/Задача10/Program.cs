// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.WriteLine("Enter tree-digit number: ");
string stringNumber = Convert.ToString(Console.ReadLine());

Console.WriteLine("Second number is "+stringNumber[1]);