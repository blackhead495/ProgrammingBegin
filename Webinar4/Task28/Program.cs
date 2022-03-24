using System;

namespace Task28
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите любое целое число: ");
            int number = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine($"{number} -> {Factorial(number)}");

            int Factorial(int A)
            {
                int Mult = 1;
                for (int i = 1; i <= A; i++)
                {
                    Mult *= i;
                }

                return Mult;
            }
        }
    }
}