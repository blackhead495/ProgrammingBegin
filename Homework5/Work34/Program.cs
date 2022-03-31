// Программа, которая создает массив, заполненный случайными положительными трехзначными числами и 
//  и находит количество четных чисел в этом массиве

using System;

namespace Work34
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
            Console.WriteLine("Количество четных чисел в массиве = " + NumEvenDigits(array));
            
            //------------------------------------------------
            void FillArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(100, 1000);   // Трехзначное случайное число 
                }
            } 
            //------------------------------------------------
            int NumEvenDigits(int[] arr)
            {
                int num = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0) num++;
                }

                return num;
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