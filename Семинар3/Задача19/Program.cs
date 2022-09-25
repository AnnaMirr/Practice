// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

Console.WriteLine("Enter five digit number: ");
string num = (Console.ReadLine()!);
int number = Convert.ToInt32(num);

if (number < 10000 | number > 100000)
    Console.WriteLine("Error number.");

else
    if (num[0] == num[4] & num[1] == num[3])
    Console.WriteLine(num + " is a Palindrom number.");
else
    Console.WriteLine($"The number is not a Palindrom: ");