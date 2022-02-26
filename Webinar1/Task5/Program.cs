// Вычислить квадрат числа при помощи функции

int sqr (int a)
{
    return (a*a);
}

Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Квадрат числа " + num + " = " + sqr(num));
