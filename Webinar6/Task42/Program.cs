// Программа, которая преобразовывает десятичное число в двоичное

using System;

namespace Task42
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите десятичное число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int dv = DecimalToBin(n);
            Console.WriteLine($"Двоичное число: {dv}");

            int DecimalToBin(int num)
            {
                if (num == 0)
                    return 0;
                else
                    return (10 * DecimalToBin(num / 2) + (num % 2));
            }
        }
    }
}