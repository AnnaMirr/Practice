// Напишите программу , которая на вход принимает число и выдает ,является ли число чётным(делится ли на 2 без остатка) (да/нет)

Console.Clear();

Console.WriteLine("Enter number a: ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"{num} - even number");
}
else
{
    Console.WriteLine((num)+" odd number");
}




