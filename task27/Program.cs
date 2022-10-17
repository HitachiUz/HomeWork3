/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int number)
{
    int len = Convert.ToString(number).Length;
    int sum = 0;
    int result = 0;

    for (int i = 1; i <= len; i++)
    {
        sum = number - number % 10;
        result = result + (number - sum);
        number = number / 10;
    }
    return result;
}

int sumNumber = SumNumber(number);
Console.WriteLine(sumNumber);

