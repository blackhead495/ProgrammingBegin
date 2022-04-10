﻿// Программа, которая принимает значения M и N
//  и выводит все натуральные числа кратные трем в промежутке от M до N.

Console.WriteLine("--- Задача 64 --------------------------------");

Console.Write("Введите 1 число : ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число : ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("----------------------------------------------");

FindMultOf3(M, N);

void FindMultOf3(int m, int n)
{
    if (m > n)
        (m, n) = (n, m);

    while ((m % 3 != 0) || (m <= 0)) // Определить следующее натуральное после М число
        m++;

    if (m > n)
    {
        Console.WriteLine("Чисел кратных 3 нет");
    }
    else
    {
        for (; m <= n; m += 3)
        {
            Console.Write(m + " ");
        }
    }
}

