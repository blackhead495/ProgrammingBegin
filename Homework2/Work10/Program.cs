// Задача 10
// Написать функцию, которая принимает трёхзначное число, а выводит это число в перевёрнутом виде

int Revers(int iNumber)
{
    int first = iNumber / 100;
    int second = (iNumber - first * 100) / 10;
    int third = iNumber - first * 100 - second * 10;
    return third * 100 + second * 10 + first;
}

Console.Write("Введите любое трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
num = Revers(num);
Console.WriteLine("Перевернутое число: " + num);