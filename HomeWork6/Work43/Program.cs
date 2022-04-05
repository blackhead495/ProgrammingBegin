// Программа, которая находит точку пересечения двух прямых линий

double k1 = 0, k2 = 0, b1 = 0, b2 = 0;

(k1, b1, k2, b2) = SetLines();
FindPoint(k1, b1, k2, b2);

//--------------------------------------------------------------
(double K1,double B1, double K2, double B2) SetLines()
{
    Console.WriteLine("Для двух прямых, заданных уравнениями вида y = kx + b, задайте их коэффициенты: ");

    Console.Write("К1: ");
    double K1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("B1: ");
    double B1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("К2: ");
    double K2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("B2: ");
    double B2 = Convert.ToDouble(Console.ReadLine());

    return (K1,B1,K2,B2);
}

//--------------------------------------------------------------
void FindPoint(double K1,double B1, double K2, double B2)
{
    if (K1 == K2)
    {
        Console.WriteLine("Прямые параллелльны! ");
    }
    else
    {
        double X = (B2 - B1) / (K1 - K2);
        double Y = K1 * X + B1;
        Console.WriteLine($"Прямые пересекаются в точке с координатами Х = {X:F}, Y = {Y:F}");
    }
}
//--------------------------------------------------------------
