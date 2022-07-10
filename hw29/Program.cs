// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


Console.WriteLine("Введите 8 чисел, для заполнения массива");

int[] Array()
{
    int[] array = new int[8];
    for (int i = 0; i <= 7; i++)
    {
        Console.Write($"Число {i+1} - ");
        array[i] = Convert.ToInt32(Console.ReadLine());

    }
    return array;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[7]}] ");

}

int[] array = new int[8];
array = Array();
printArray(array);