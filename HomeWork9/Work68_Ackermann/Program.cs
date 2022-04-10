// Программа, которая принимает значения M и N
//  и выводит значение функции Аккермана от M и N.

using System.Threading.Channels;

Console.WriteLine("--- Задача 68 --------------------------------");

Console.Write("Введите 1 число : ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число : ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("----------------------------------------------");

Console.WriteLine($"Результат функции Ackermann({M}, {N}) = {FuncAckermann(M, N)}");

//------------------------------------------------------
int FuncAckermann(int m, int n) 
{
    if (m == 0)
        return n + 1;
    
    else if (n == 0 && m > 0)
        return FuncAckermann(m - 1, 1);
        
    else
        return FuncAckermann(m - 1, FuncAckermann(m, n - 1));
}
//------------------------------------------------------
