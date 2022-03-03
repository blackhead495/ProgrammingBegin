// Задача 13
// Программ, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdNumber(int iNumber)
{
    int i = 0;
    int[] a = new int[10]; // Достаточное количество цифр для типа int

    while (iNumber > 0)
    {
        a[i++] = iNumber % 10;
        iNumber /= 10;
    }

    return (i > 2) ? a[i - 3] : -1;
}
    

Console.Write("Введите любое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int third = ThirdNumber(number);

if (third >= 0)
    Console.WriteLine($"Третья цифра введенно числа = {third}");
else
    Console.WriteLine("Введенное число имеет меньше 3 цифр");


