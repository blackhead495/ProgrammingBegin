// Программа, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

using System;

namespace Task30
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] a = new int[8];
            Random rand = new Random();
            for (int i = 0; i < 8; i++)
            {
                a[i] = rand.Next(0, 2);
                Console.Write($"{a[i]}, ");
            }
            
            Console.WriteLine(" ");
        }
    }
}