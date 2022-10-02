// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе


int SumNumber(string number, int counter)
{

    int numberN = Convert.ToInt32(number);
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        result = result + numberN % 10;
        numberN = numberN / 10;
    }
    return result;
}

Console.Write("Enter number: ");
string numberN = Console.ReadLine() ?? "0";

int sumNumber = SumNumber(numberN, numberN.Length);
Console.WriteLine("The sum of the digits of your number: " + sumNumber);