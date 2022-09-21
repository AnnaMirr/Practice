// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Clear();


Console.WriteLine("Enter tree-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);



if (stringNumber.Length > 2)
{
    Console.WriteLine("Third number is "+stringNumber[2]);
}
else{
    Console.WriteLine("Third number doesn't exist.");
}
