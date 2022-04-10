// Программа, которая принимает значения M и N
//  и выводит все натуральные числа кратные трем в промежутке от M до N.

Console.WriteLine("--- Задача 64 --------------------------------");


Console.Write("Введите 1 число : ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число : ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("----------------------------------------------");
if (M > N)
    (M, N) = (N, M);

int num = M;

while (num % 3 != 0) // Определить следующее после М число
    num++;

if (num > N)
{
    Console.WriteLine("Чисел кратных 3 нет");
}
else
{
    for (int i = num; i <= N; i+=3)
    {
        Console.Write(i + " ");
    }
}

