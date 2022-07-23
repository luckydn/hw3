/*
Задача 60. Сформируйте трёхмерный массив из 
неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, 
добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)
*/

int[,,] generateArray(int length, int width, int height)
{
    int count = 0;
    int[,,] resultArray = new int[length, width, height];
    for (int x = 0; x < length; x++)
    {
        for (int y = 0; y < width; y++)
        {
            for (int z = 0; z < height; z++)
            {
                resultArray[x, y, z] = (10 + (x + y + z) + count);
            }
            count = count + (height - 1);
        }
        count = count + (width - 1);
    }
    return resultArray;
}

void printYellow(int number)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write($"{number}\t");
    Console.ResetColor();
}
void print3DArray(int[,,] array)
{
    Console.Write("\t");
    for (int x = 0; x < array.GetLength(1); x++)
    {
        printYellow(x);

    }
    Console.WriteLine();
    for (int x = 0; x < array.GetLength(0); x++)
    {
        printYellow(x);
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write(array[x, y, z]);
                Console.Write("\t");
            }
        }
        Console.WriteLine("\t");
    }
}

void printNewArray(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.WriteLine($"{array[x, y, z]} ({x},{y},{z})");
            }
        }

    }
}

int[,,] new3darray = generateArray(3, 3, 3);
print3DArray(new3darray);
printNewArray(new3darray);