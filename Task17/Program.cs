// See https://aka.ms/new-console-template for more information
static  void Quadrant(int x, int y)
{
    if (x>0 && y>0)     
    {
        Console.WriteLine("Точка лежит в первой четверти ");
    }
    else if (x<0 && y>0)     
    {
        Console.WriteLine("Точка лежит во второй четверти ");
    }
    else if (x<0 && y<0)     
    {
        Console.WriteLine("Точка лежит в третьей четверти ");
    }
    else if (x>0 && y<0)     
    {
        Console.WriteLine("Точка лежит в четвертой четверти ");
    }
}

int[] coord = new int[2];

Console.Write("Введите X: ");
coord[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
coord[1] = Convert.ToInt32(Console.ReadLine());

Quadrant(coord[0], coord[1]);
