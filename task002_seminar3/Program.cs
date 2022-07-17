// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

Console.WriteLine("Эта программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

Console.WriteLine("Введите координаты первой точки");

Console.Write("X1 :");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 :");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1 :");
int n3 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты второй точки");
Console.Write("X2 :");
int n4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 :");
int n5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2 :");
int n6 = Convert.ToInt32(Console.ReadLine());

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dis = Math.Sqrt(
        (x2 - x1) * (x2 - x1)
        + (y2 - y1) * (y2 - y1)
        + (z2 - z1) * (z2 - z1));
    return dis;

}

Console.WriteLine(Distance(n1, n2, n3, n4, n5, n6));