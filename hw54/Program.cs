/*
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по 
убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:

1 2 4 7
2 3 5 9
2 4 4 8
*/

Console.Write("Введите количество строк -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов -> ");
int n = Convert.ToInt32(Console.ReadLine());

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

int[,] sortArray(int[,] array)
{
    int[,] resultArray = array;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int e = 0; e < array.GetLength(1); e++)
            {

                if (array[i, j] < array[i, e])
                {
                    int buffer = array[i, j];
                    array[i, j] = array[i, e];
                    array[i, e] = buffer;
                }
                
            }
        }
    }
    return resultArray;
}

int[,] myNewArray = generateArray(m, n, 10);
print2DArray(myNewArray);
Console.WriteLine("");
int[,] newSortArray = sortArray(myNewArray);
print2DArray(newSortArray);
