// Программа, которая изменяет знаки элементов массива

using System;

namespace Task32
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[4];
            FillArray();
            PrintArray();
            Reverse();
            PrintArray();
            
            void FillArray()
            {
                Random rand = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(-9, 10);
                }
            }
            
            void PrintArray()
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine(""); // Переход на новую строку
            }

            void Reverse()
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] *= -1;
                }
            }
        }
    }
}