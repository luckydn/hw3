/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int sumNumberRecurse(int numberStart, int numberEnd)
{
    return numberEnd==numberStart?numberStart: numberEnd+sumNumberRecurse(numberStart, numberEnd-1);
}


Console.Write(sumNumberRecurse(1, 15));