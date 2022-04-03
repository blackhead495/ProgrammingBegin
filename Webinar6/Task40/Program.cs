// Программа, которая принимает на вход три числа и проверяет, может ли существовать треугольник 
// со сторонами такой длины

using System;

namespace Task40
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] treug = new int[3];
            FillArray(treug);
            Console.WriteLine($"Треугольник с такими сторонами {ResolveTreug(treug)}существует");

            //-----------------------------------------
            void FillArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"Введите длину {i+1} стороны: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //-----------------------------------------
            string ResolveTreug(int[] arr)
            {
                if ((arr[0]+arr[1])>arr[2] &&
                    (arr[1]+arr[2])>arr[0] &&
                    (arr[2]+arr[0])>arr[1] )
                {
                    return "";
                }

                return "не ";
            }
        }
    }
}