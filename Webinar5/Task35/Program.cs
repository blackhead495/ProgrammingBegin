// Программа, которая создает одномерный массив из 123 случайных чисел 
//  и находит количество элементов в этом массиве, значения которых лежат
//  в отрезке [10, 99]

using System;

namespace Task35
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[123];
            FillArray();
            PrintArray();
            Console.WriteLine($"Количество чисел = {SearchNumber()}");
            
            
            //------------------------------------------------
            void FillArray()
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(200);
                }
            }
            //------------------------------------------------
            void PrintArray()
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
            //------------------------------------------------
            int SearchNumber()
            {
                int num = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 10 && array[i] < 99)
                    {
                        num++;
                    }
                }

                return num;
            }
            //------------------------------------------------
        }
    }
}