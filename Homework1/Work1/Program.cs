// Задача 2
// Какое из двух введеных чисел больше

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b) Console.WriteLine("max = " + a);
else      Console.WriteLine("max = " + b);