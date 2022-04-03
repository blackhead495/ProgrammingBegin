// Программа, которая находит точку пересечения двух прямых линий

double[] KoordDot = new Double[2];
double[] Koeff = new Double[4];

Koeff = SetLines();
FindPoint(Koeff, KoordDot);
Console.WriteLine($"Координаты точки пересечения прямых: X = {KoordDot[0]:F}, Y = {KoordDot[1]:F}");

//--------------------------------------------------------------
double[] SetLines()
{
    double[] K = new Double[4];
    Console.WriteLine("Для двух прямых, заданных уравнениями вида y = kx + b, задайте их коэффициенты: ");

    Console.Write("К1: ");
    K[0] = Convert.ToDouble(Console.ReadLine());

    Console.Write("B1: ");
    K[1] = Convert.ToDouble(Console.ReadLine());

    Console.Write("К2: ");
    K[2] = Convert.ToDouble(Console.ReadLine());

    Console.Write("B2: ");
    K[3] = Convert.ToDouble(Console.ReadLine());

    return K;
}

//--------------------------------------------------------------
void FindPoint(double[] Lines, double[] Dot)
{
    Dot[0] = (Lines[3] - Lines[1]) / (Lines[0] - Lines[2]);
    Dot[1] = Lines[0] * Dot[0] + Lines[1];
}
//--------------------------------------------------------------
