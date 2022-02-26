// Задача 8
// Вывести все четные числа от 1 до N

Console.Write("Введите целое положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 2)
{
    Console.WriteLine("Нет четных чисел");
}
else
{
    int k = 2;

    while (k <= a)
    {
        Console.Write(" " + k);
        k += 2;
    }
}