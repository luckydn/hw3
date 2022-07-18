/*
Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

Console.Write("Введите количество строк -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов -> ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] generateArray(int row, int col, int deviation)
{
    double[,] myArray = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
            myArray[i, j] = new Random().Next(-deviation, deviation + 1);
    }
    return myArray;
}
void printGreen(int number)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{number}\t");
    Console.ResetColor();
}
void printMyArray(double[,] array)
{
    Console.Write("\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        printGreen(i);

    }
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        printGreen(i);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write("\t");
        }
        Console.WriteLine("\t");
    }
}

void resultNumberElement(double[,] array, int number)
{
    int count = 0;
    if (number > 0 && number <= (array.GetLength(0) * array.GetLength(1)))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                count++;
                if(count==number)
                Console.Write($"Значение {number}-го элемента, равно -> {array[i, j]}");

            }
        }
    }
    else if(number > (array.GetLength(0) * array.GetLength(1)))
        {
            Console.Write("Такого числа в массиве нет");
        }
    else if(number <=0)
    {
            Console.Write("Такого числа в массиве нет");
    }
}


double[,] myNewArray = generateArray(m, n, 10);
printMyArray(myNewArray);
Console.Write("Введите позицию элемента от 1 до ... -> ");
int numberPosition = Convert.ToInt32(Console.ReadLine());
resultNumberElement(myNewArray, numberPosition);