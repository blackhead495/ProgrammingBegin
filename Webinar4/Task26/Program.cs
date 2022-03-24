// Программа, которая принимает число и выдает количество цифр в этом числе

using System;

namespace Task26
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите любое целое число: ");
            int number = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine($"{number} -> {NumDigits(number)}");

            int NumDigits(int A)
            {
                int i = 0;
                while (A != 0)
                {
                    A /= 10;
                    i++;
                }

                return i;
            }
        }
    }
}