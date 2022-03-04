// Задача 21
// Программа, которая принимает на вход координаты точек А и В и находит расстояние между ними в 3D пространстве.

double[] A = new double[3];
double[] B = new double[3];

Console.Write("Введите координату Х точки А: ");
A[0] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
A[1] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
A[2] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Х точки B: ");
B[0] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
B[1] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
B[2] = Convert.ToDouble(Console.ReadLine());

Console.Write("расстояние между точками A и B = " + Distance(A[0],A[1],A[2],B[0],B[1],B[2]));

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distx = Math.Pow(x1 - x2, 2);
    double disty = Math.Pow(y1 - y2, 2);
    double distz = Math.Pow(z1 - z2, 2);
    return Math.Sqrt(distx + disty + distz);
}
