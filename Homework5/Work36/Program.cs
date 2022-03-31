// Программа, которая создает одномерный массив случайных чисел и
//  находит сумму элементов, стоящих на нечетных позициях

using System;

namespace Work36
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int L = 10;                   // Задать длину массива
            int[] array = new int[L];     // Создать массив заданной длины
            
            Random rnd = new Random();
            
            FillArray(array);
            PrintArray(array);
            Console.WriteLine("Сумма элементов, стоящих на нечетных позициях = " + SummOddPositions(array));
            
            //------------------------------------------------
            void FillArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(100);   // Случайное число 
                }
            } 
            //------------------------------------------------
            int SummOddPositions(int[] arr)
            {
                int Summ = 0;
                for (int i = 1; i < arr.Length; i+=2)
                {
                    Summ += arr[i];
                }

                return Summ;
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
            //------------------------------------------------
        }
    }
}