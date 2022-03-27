// Программа, которая находит произведение пар чисел в одномерном массиве и записывает эти произведения 
// в новый массив. Парой считаются первый и последний, второй и предпоследний, и т.д.

using System;

namespace Task37
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const int num = 4;         // Количество элементов в массиве
            const int maxValue = 20;   // Максимальное значение случайного числа
            
            int[] array = new int[num];
            int[] mult = new int[num / 2];
            
            FillArray(array);
            PrintArray(array);
            MultiPlication(array, mult);
            PrintArray(mult);

            //------------------------------------------------
            void FillArray(int[] arr)
            {
                Random rnd = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(maxValue);
                }
            }
            //------------------------------------------------
            void MultiPlication(int[] arr, int[] arr2)
            {
                int k = arr.Length;

                for (int i = 0; i < k/2; i++)
                {
                    arr2[i] = arr[i] * arr[k - i - 1];
                }
            }
            //------------------------------------------------
            void PrintArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}