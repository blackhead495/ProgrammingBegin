// Программа (цикл), которая принимает два числа А и В, и возводит число А в натуральную степень числа В

using System;

namespace Work25
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите первое целое число: ");
            int A = Convert.ToInt32((Console.ReadLine()));
            Console.Write("Введите второе целое число: ");
            int B = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine($"{A} в степени {B} равен {Math.Pow(A, B)} ");
        }
    }
}