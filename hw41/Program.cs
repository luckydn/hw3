/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите количество цифр, среди которых программа определит сколько чисел больше 0  -> ");
int l = Convert.ToInt32(Console.ReadLine());

int[] newArray(int lenght)
{
    int[] myArray = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        Console.Write($"Введите {i + 1} элемент -> ");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return myArray;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int positiveElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] myNewArray = newArray(l);
printArray(myNewArray);
int result = positiveElement(myNewArray);
Console.WriteLine($" - Чисел больше 0 -> [{result}]");
