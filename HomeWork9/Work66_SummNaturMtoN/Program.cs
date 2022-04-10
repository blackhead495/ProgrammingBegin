// Программа, которая принимает значения M и N
//  и выводит сумму натуральных элементов в промежутке от M до N.

using System.Threading.Channels;

Console.WriteLine("--- Задача 66 --------------------------------");

Console.Write("Введите 1 число : ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число : ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("----------------------------------------------");

if (M > N)              // Нужно от меньшего к большему
    (M, N) = (N, M);

Console.WriteLine($"Сумма чисел от {M} до {N} = {Summ(M,N)}");

//----------------------------------------------
int Summ(int m, int n)
{
    if (m == n)
        return m;
    
    else
        return m + Summ(m + 1, n);
}
//----------------------------------------------