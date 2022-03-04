// Задача 23
// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите любое натуральное число ");
int N = Convert.ToInt32(Console.ReadLine());
Cube(N);

void Cube(int n)
{
    Console.Write($"{n} -> ");
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"{Math.Pow(i,3)}, ");
    }
}