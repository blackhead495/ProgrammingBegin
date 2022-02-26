using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число : ");
            int square = Convert.ToInt32(Console.ReadLine());
            if (number*number == square)
            {
                Console.WriteLine("Второе число является квадратом первого");
            }
            else
            {
                Console.WriteLine("Второе число не является квадратом первого");
            }
        }
    }
}