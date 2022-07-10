// Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите числа A и B что бы возвести A в степерь B");
Console.Write("A = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("B = ");
int B = Convert.ToInt32(Console.ReadLine());

int degree(int number1, int number2)
{
    int result = number1;

    for (int i = 1; i < number2; i++)
    {
        result = result * number1;
    }
    return result;
}

int deegreeAB = degree(A, B);
Console.WriteLine($"{A}^{B} = {deegreeAB}");
