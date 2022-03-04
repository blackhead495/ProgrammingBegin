// Задача 19
// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите любое пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Это число {CheckPoly(num)}является полиндромом.");

string CheckPoly(int t)
{
    int[] a = new int[5];
    for (int i = 0; i < 5; i++)
    {
        a[i] = t % 10;
        t /= 10;
    }

    if (a[0]==a[4] && a[1]==a[3])
        return "";
    else
        return "не ";
}