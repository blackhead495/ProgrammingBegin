// Задача 15
// Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool dayOfWeek(int numDay)
{
    return numDay > 5 ? true : false;
}

Console.Write("Введите номер дня недели (1..7) : ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 & num <= 7)
{
    if (dayOfWeek(num))
        Console.WriteLine("Это выходной день");
    else
        Console.WriteLine("Это рабочий день");
} 
else 
    Console.WriteLine("Неправильно введенное число");
