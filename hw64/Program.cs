/*
Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в 
промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""
*/

void naturalNumbers(int numbers)
{
    if(numbers==1)
    {
        Console.Write($"{numbers}, ");
    }
    else
    {
        naturalNumbers(numbers-1);
        Console.Write($"{numbers}, ");
    }
}

Console.WriteLine("Введите число N и программа отобразит все числа от 1 до N");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {n} -> ");
naturalNumbers(n);