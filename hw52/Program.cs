/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Write("Введите количество строк -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов -> ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] generateArray(int row, int col, int deviation)
{
    int[,] myArray = new int[row, col];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            myArray[i, j] = new Random().Next(deviation - deviation, deviation + 1);
        }
    }
    return myArray;
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
double[] averageColArray(int[,] my2dArray)
{
    double[] result = new double[my2dArray.GetLength(1)];
    int index = 0;
    int j = 0;
    while (j < my2dArray.GetLength(1))
    {
        for (int i = 0; i < my2dArray.GetLength(0); i++)
        {
            result[index] = (result[index] + my2dArray[i, j]);
            if(i==my2dArray.GetLength(0)-1)
            {
                result[index] = (result[index] / my2dArray.GetLength(0));
            }
        }
        j++;
        index++;
    }
    return result;
}

void printAverageColArray(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца -> ");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write("; ");
        }
    }
    Console.Write("]");
}

int[,] myNewArray = generateArray(m, n, 10);
print2DArray(myNewArray);
double[] resultAverage = averageColArray(myNewArray);
printAverageColArray(resultAverage);