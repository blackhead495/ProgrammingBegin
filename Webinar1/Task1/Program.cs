using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Квадрат числа = " + number*number);
        }
    }
}
