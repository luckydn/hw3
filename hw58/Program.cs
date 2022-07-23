/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.

Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

и

1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:

1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49*/

int[,] generateArray(int row, int col, int deviation)
{
    int[,] resultArray = new int[row, col];
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                resultArray[i, j] = new Random().Next(1, deviation + 1);
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

int[,] productOfNumberArray(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            result[i,j] = (array1[i,j]*array2[i,j]);
        }
    }
    return result;
}

int[,] myNewArray1 = generateArray(4,5,10);
print2DArray(myNewArray1);

Console.WriteLine("");

int[,] myNewArray2 = generateArray(4,5,10);
print2DArray(myNewArray2);

Console.WriteLine("");

int[,] productArray = productOfNumberArray(myNewArray1, myNewArray2);
print2DArray(productArray);
