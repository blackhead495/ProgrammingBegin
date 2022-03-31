// Программа, которая создает массив, заполненный случайными числами и
// находит разницу между максимальным и минимальным значением в этом массиве.

using System;

namespace Work38
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            int L = 10;                         // Задать длину массива
            double[] array = new double[L];     // Создать массив заданной длины
            
            Random rnd = new Random();
            
            FillArray(array);
            PrintArray(array);
            Console.WriteLine("Разница между максимальным и минимальным числом = " + Amplituda(array));

            
            //------------------------------------------------
            void FillArray(double[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = (rnd.NextDouble());    // Получить вещественное число от 0 до 1
                    arr[i] *= rnd.Next(-100, 100);   // Можно расширить диапазон чисел от -100 до 100
                }
            } 
            //------------------------------------------------
            void PrintArray(double[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("{0:F8} ", arr[i]);
                }
                Console.WriteLine();
            }
            //------------------------------------------------
            double Amplituda(double[] arr)
            {
                double Max = 0, Min = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > Max) Max = arr[i];
                    if (arr[i] < Min) Min = arr[i];
                }

                return Max - Min;
            }
            //------------------------------------------------
        }
    }
}