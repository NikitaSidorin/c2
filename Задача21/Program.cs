Console.WriteLine("Введите x координату точки 1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y координату точки 1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z координату точки 1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x координату точки 2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y координату точки 2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z координату точки 2");
int z2 = Convert.ToInt32(Console.ReadLine());

double Getdistance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Round(Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2)),2);
    return dist;
}
Console.WriteLine($"Дистанция между: {Getdistance(x1, y1, z1, x2, y2, z2)}");
