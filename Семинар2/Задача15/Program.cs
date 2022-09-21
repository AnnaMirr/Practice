// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.WriteLine("Enter number from 1 to 7: ");
int numberDay = Convert.ToInt32(Console.ReadLine());


if (numberDay == 6 || numberDay == 7)
{
    Console.WriteLine("This is a weekend day! Hurrah!");
}
else if (numberDay < 6 || numberDay > 7);
{
    Console.WriteLine("Sorry, this is not a weekend day.");
}

// For countries whose day of the week starts on Monday.