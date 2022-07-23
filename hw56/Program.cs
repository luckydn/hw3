/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с 
наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


int[,] generateArray(int row, int col, int deviation)
{
    int[,] resultArray = new int[row, col];
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                resultArray[i, j] = new Random().Next(0, deviation + 1);
            }
        }
    }
    return resultArray;
}

void printYellow(int number)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write($"{number}\t");
    Console.ResetColor();
}
void print2DArray(int[,] array)
{
    Console.Write("\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        printYellow(i);

    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printYellow(i);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write("\t");
        }
        Console.WriteLine("\t");
    }
}

int[] SumElementColOfArray(int[,] array)
{
    int[] result = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i] = (result[i] + array[i, j]);
        }
    }
    return result;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Сумма элементов в {i + 1}-й строке - {array[i]}");
        
    }
}

void minSumColArray(int[] array)
{
    int numberCol = array[0];
    int indexcol = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (numberCol > array[i])
        {
            numberCol = array[i];
            indexcol = i;
        }

    }
    Console.Write($"Минимальная сумма элементов = {numberCol} в {indexcol+1}й строке");
}

int[,] myNewArray = generateArray(4, 6, 10);
print2DArray(myNewArray);
int[] arraySumElement = SumElementColOfArray(myNewArray);
printArray(arraySumElement);
minSumColArray(arraySumElement);
