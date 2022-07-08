Console.WriteLine("Введите число N, что бы программа отобразила таблицу кубов чисел от 1 до N");
int N = Convert.ToInt32(Console.ReadLine());
int i = 0;
double result;
for (i=1; i<N; i++)
    {
        result= Math.Pow(i, 3);
        Console.Write($"{result}, ");
    }

result = Math.Pow(i, 3);
Console.WriteLine(result);