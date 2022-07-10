// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Напиши число N, что бы программа выдала сумму цифр в числе");
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());

int sumOfRange(int number)
{
    int result = 0;

    while (number != 0)
    {
        result = result + (number % 10);
        number = number / 10;
    }
    return result;
}

int sum = sumOfRange(N);
Console.WriteLine($"Сумма цифр в числе {N} --> {sum}");