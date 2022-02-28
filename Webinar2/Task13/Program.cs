// Кратно ли введенное число числам 7 и 23 одновременно.

using System.ComponentModel.Design;

Random rand = new Random();
int InputNumber = rand.Next(1, 10000);

if ((InputNumber % 7 == 0) && (InputNumber % 23 == 0))
{
    Console.WriteLine( InputNumber + " Число кратно");
}
else
{
    Console.WriteLine(InputNumber + " Число не кратно");
}
