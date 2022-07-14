/* Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Введите длину массива");
int lengthArray = Convert.ToInt32(Console.ReadLine());

int[] randomArray(int length)
{
    int[] resultArray = new int[length];
    for (var i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(100, 999);
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

int evenNumbers(int[] newArray)
{
    int count = 0;
    for(var i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] % 2 == 0)
        {   
            count = count + 1;
        }
    }
    return count;
}

int[] newArray = randomArray(lengthArray);
printArray(newArray);
int evenNumbersCount = evenNumbers(newArray);
Console.WriteLine($" количество четных чисел -> {evenNumbersCount}");


