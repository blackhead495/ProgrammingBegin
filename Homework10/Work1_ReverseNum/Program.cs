// Программа, которая записывает полученное числов в обратном порядке

Console.Write("Введите целое положительное число : ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(number);
Revers(number);
Console.WriteLine();

//----------------------------------------
void Revers(int num, int result = 0)
{
    if (num == 0)
    {
        Console.Write(" -> " + result);
        return;
    }

    result = result * 10 + num % 10;
    num /= 10;
    Revers(num, result);
}
//----------------------------------------
