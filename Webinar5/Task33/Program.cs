// программа, которая определяет, присутствует ли заданное число в массиве

using System;

namespace Task33
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 15, 25, 3, 7, 18, 31, 6 };
            Console.Write("Введите целое число: ");
            int num = Convert.ToInt32((Console.ReadLine()));
            if (CheckNum())
                Console.WriteLine($"Число {num} есть в массиве");
            else
                Console.WriteLine($"Числа {num} нет в массиве");

                //------------------------------------------
            bool CheckNum()
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == num)
                    {
                        return true;
                    }
                }

                return false;
            }
            //-------------------------------------------
        }
    }
}