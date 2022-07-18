/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

Console.Write("Введите количество строк -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов -> ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] newArray(int row, int col, int deviation)
{
    double[,] resultArray = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            resultArray[i,j] = new Random().Next(-deviation, deviation+1) / 10.0;
        }
    }
    return resultArray;
}
void printGreen(int number)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{number}\t");
    Console.ResetColor();
}

void print2DArray(double[,] Array)
{
    Console.Write("\t");
    for (int i = 0; i < Array.GetLength(1); i++)
    {
        printGreen(i);

    }
    Console.WriteLine();

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        printGreen(i);
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i, j]);
            Console.Write("\t");
        }
        Console.WriteLine("\t");
    }
}

// void printMyArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j]);
//             Console.Write("\t");
//     }
//     Console.Write("\t");
// }

double[,] myNewArray = newArray(m, n, 100);
print2DArray(myNewArray);