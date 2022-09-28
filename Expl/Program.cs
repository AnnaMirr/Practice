int power(int baseNum, int deg)
{
    int result = 1;

    for (int i = 0; i < deg; i++)
        result *= baseNum;

    return result;
}


int number = 0;
int degree = 0;

Console.Write("Input A: ");
number = Convert.ToInt32(Console.ReadLine());

while (true)
{
    Console.Write("Input B: ");
    degree = Convert.ToInt32(Console.ReadLine());
    if (degree > 0)
        break;
    else
        Console.WriteLine("The degree must be more then 0");
}


Console.WriteLine(power(number, degree));