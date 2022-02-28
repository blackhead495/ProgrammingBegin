// Программа которая принимает на вход два числа и проверяет
//  является ли второе квадратом перового
string ifStr(int t, int tt)
{
    if (t * t == tt)
        return "";
    else
        return "!";
}

Console.Write("Введите первое число:  ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:  ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} x {a} {ifStr(a,b)}= {b}");
