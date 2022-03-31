using System;

namespace Example16_Fibonacci
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double Fibonacci(int n)
            {
                if (n==1 || n==2)
                {
                    return 1;
                }
                else
                {
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
                }
            }

            // Начиная примерно с 40 номера вычисления происходят очень медленно
            for (int i = 1; i < 50; i++)
            {
                Console.WriteLine($"f({i}) = {Fibonacci(i)}");
            }
        }
    }
}