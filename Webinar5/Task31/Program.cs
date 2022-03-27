// Задать массив из 12 элементов, заполненный случайными числами из промежутка [-9,9].
// Найти сумму отрицательных и положительных элементов массива

using System;

namespace Task31
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[12];
            
            
            FillArray();
            PrintArray();
            PosAndNeg();
            
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
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine(""); // Переход на новую строку
            }

            void PosAndNeg()
            {
                int positiv = 0;
                int negativ = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                        positiv += array[i];
                    else
                        negativ += array[i];
                }
                Console.WriteLine($"Сумма положительных чисел равна {positiv}");
                Console.WriteLine($"Сумма отрицательных чисел равна {negativ}");
            }
        }
    }
}