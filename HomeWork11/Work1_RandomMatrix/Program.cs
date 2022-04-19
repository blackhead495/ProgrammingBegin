// Программа, которая принимает два числа n и m такие, что n < m и
// заполняет массив случайными числами из промежутка [n, m];

using System;

int k = 10, t = 10;  // размеры массива
double[,] array = new double[k, t];


Console.Write("Введите первое число : ");
double n = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число : ");
double m = Convert.ToDouble(Console.ReadLine());

if (n > m)  (n, m) = (m, n);   // n должно быть меньше m

double diff = m - n;

Random rand = new Random();

for(int i = 0; i < k; i++)
{
    for (int j = 0; j < t; j++)
    {
        array[i, j] = rand.NextDouble() * diff + n;
    }
}

for (int i = 0; i < k; i++)
{
    for (int j = 0; j < t; j++)
    {
        Console.Write("{0,8:N3} ", array[i, j]);
    }

    Console.WriteLine();
}