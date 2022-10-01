// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int power(int baseNum, int deg)
{
    int result = 1;

    for (int i = 0; i < deg; i++)
        result *= baseNum;

    return result;
}

Console.WriteLine("Enter number: ");
int baseNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the degree for your number: ");
int deg = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(power(baseNum, deg));