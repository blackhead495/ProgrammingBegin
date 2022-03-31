using System;

namespace Example15_Factorial
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double Factorial(int num)
            {
                // 1! = 1
                // 0! = 1

                if (num == 1) 
                    return 1;
                else
                    return Factorial(num - 1) * num;
            }

            for (int i = 1; i < 40; i++)
            {
                Console.WriteLine($"{i}! = {Factorial(i)}");
            }
            
        }
    }
}