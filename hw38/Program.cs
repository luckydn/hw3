/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

Console.Write("Введите длину массива -> ");
int lengthArray = Convert.ToInt32(Console.ReadLine());


double[] myArray(int length)
{
    double[] resultArray = new double[length];
    for (var i = 0; i < length; i++)
    {
        Console.Write($"Введите {i+1} элемент массива -> ");
        resultArray[i] = Convert.ToDouble(Console.ReadLine());
    }
    return resultArray;
}

void printArray(double[] printArray)
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
    Console.WriteLine("]");
}

double minElement(double[] myArray)
{
    double minN = myArray[0];
    for(var i = 1; i < myArray.Length; i++)
    {
       if (minN > myArray[i])
       {
        minN = myArray[i];
       }
    }
    return minN;
}

double maxElement(double[] myArray)
{
    double maxN = myArray[0];
    for(var i = 1; i < myArray.Length; i++)
    {
       if (maxN < myArray[i])
       {
        maxN = myArray[i];
       }
    }
    return maxN;
}

double rangeMinMax(double min, double max)
{
    double result = 0;
    result = max - min;
    return result;
}

double[] newArray = myArray(lengthArray);
printArray(newArray);
double minNumber = minElement(newArray);
double maxNumber = maxElement(newArray);
double range = rangeMinMax(minNumber, maxNumber);

Console.WriteLine($" минимальный элемент -> {minNumber}");
Console.WriteLine($" максимальный элемент -> {maxNumber}");
Console.WriteLine($" разница между {minNumber} и {maxNumber} равна -> {range}");