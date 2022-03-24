// Программа, которая принимает на вход число А и выдает суммму чисел от 1 до А

using System;

namespace Task24
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите любое целое число: ");
            int number = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine($"{number} -> {SummN(number)}");

            int SummN(int A)
            {
                int summ = 0;

                for (int i = 1; i <= A; i++)
                {
                    summ += i;
                }

                return summ;
            }
        }
    }
}