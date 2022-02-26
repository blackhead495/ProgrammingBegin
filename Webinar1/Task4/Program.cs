// Вывести все числа от -N до N

Console.Write("Введите целое число : ");
int num = Convert.ToInt32(Console.ReadLine());
int k = (-1) * Math.Abs(num);

Console.WriteLine(" ");
while (k <= num)
{
    Console.Write(" " + k++);
}

