// Программа, которая задает массив из 8 случайных целых чисел и выводит отсортированный по модулю массив

using System;

namespace Work29
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] a = new int[8];
            Random rand = new Random();
            
            for (int i = 0; i < 8; i++)
            {
                a[i] = rand.Next(-100, 101);
            }

            for (int j = 0; j < 8; j++)
            {
                for (int i = 7; i > j; i--)
                {
                    // Меньшее число сдвинуть в начало
                    if (Math.Abs(a[i]) < Math.Abs(a[i - 1]))
                    {
                        (a[i], a[i-1]) = (a[i-1], a[i]); // -- swap --
                    }
                }
                Console.Write($"{a[j]} ");
            }
        }
    }
}