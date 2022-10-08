// число 5 знаков папалиндром (2ой вариант)

void Palindrom()
{
    int number = 123321;
    int result = 0;
    while (number > 0)
    {
        int digit = number % 10;
        result = result * 10 + digit;
        number /= 10;
        Console.WriteLine(result);
    }
    if (number == result)
    {
        Console.WriteLine($"Number {number} is a palindrom.");
    }
    else 
    {
        Console.WriteLine($"Number {number} isn't a palindrom.");
    }

}
Palindrom();