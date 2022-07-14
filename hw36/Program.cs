/* 
Задача 36: Задайте одномерный массив, 
заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

Console.Write("Введите длину массива -> ");
int lengthArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива -> ");
int startBorder = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива -> ");
int endBorder = Convert.ToInt32(Console.ReadLine());

int[] randomArray(int length, int startBorder, int endBorder)
{
    int[] resultArray = new int[length];
    for (var i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startBorder, endBorder);
    }
    return resultArray;
}

void printArray(int[] printArray)
{
    Console.Write("[");
    for (var i = 0; i < printArray.Length; i++)
    {
        Console.Write(printArray[i]);
        if (i < printArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int sumElementOfNegative(int[] myArray)
{
    int sumElement = 0;
    for(var i = 1; i < myArray.Length; i = i + 2)
    {
       sumElement = sumElement + myArray[i];
    }
    return sumElement;
}

int[] newArray = randomArray(lengthArray, startBorder, endBorder);
printArray(newArray);
int sumElementOfNegativeIndex = sumElementOfNegative(newArray);
Console.WriteLine($" сумма чисел находящихся под нечетным ИНДЕКСОМ -> {sumElementOfNegativeIndex}");


