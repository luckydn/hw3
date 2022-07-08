Console.Write("введите координату Ax - ");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координату Ay - ");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координату Az - ");
double Az = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координату Bx - ");
double Bx = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координату By - ");
double By = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координату Bz - ");
double Bz = Convert.ToDouble(Console.ReadLine());


double distance = Math.Sqrt(Math.Pow((Ax - Bx),2) + Math.Pow((Ay - By), 2) + Math.Pow((Az - Bz), 2));
Console.WriteLine($"Растояние между точками = {distance}");