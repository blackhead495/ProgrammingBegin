// Программа, которая принимает число и выдает сумму цифр в числе

using System;

namespace Work27
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int A = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine($"Сумма цифр числа {A} равна {SummDigits(A)} ");

            //------------------------------------------------------------------
            int SummDigits(int num)
            {
                int summ = 0;
                while (num != 0)
                {
                    summ += num % 10;
                    num /= 10;
                }

                return summ;
            }
            
        }
    }
}