// Программа, которая принимает первые 2 значения Фибоначчи
//  и выводит 5 чисел последовательности Фибоначчи

using System.Threading.Channels;

Console.WriteLine("--- Задача 70 --------------------------------");

Console.Write("Введите 1 число Фибоначчи : ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число Фибоначчи : ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество чисел Фибоначчи : ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("----------------------------------------------");

Fibo(A, B, num);

void Fibo(int a, int b, int n)
{
    if (n == 0)
    {
        Console.WriteLine("\n----------------------------------------------");
        return; 
    }
    else
    {
        Console.Write($"{a} ");
        (a, b) = (b, a + b);
        Fibo(a,b,n-1);
    }
}