string[] day = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

Console.Write("Введите номер для недели : ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(day[num-1]);

