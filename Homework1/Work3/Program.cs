// Задача 6
// Является ли число четным

Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(Convert.ToBoolean(a % 2)) Console.WriteLine("Число " + a + " нечётное");
else                         Console.WriteLine("Число " + a + " чётное");