Console.WriteLine("Введите пятизначное число для определения, является ли оно палиндромом");
int n = Convert.ToInt32(Console.ReadLine());

int An = n / 10000;
int Bn = (n / 1000) % 10;
int Cn = (n / 100) % 10;
int Dn = (n / 10) % 10;
int En = (n % 10);

if(An == En)
    {
        if(Bn == Dn)
        Console.WriteLine($"{n} --> Палиндром");
    }
else
    {
        Console.Write($"{n} --> Не является Палиндромом");
    }
