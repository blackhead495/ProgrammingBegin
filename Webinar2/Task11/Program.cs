// Вывести наибольшую цифру каждого из 10 случайных двузначных чисел.

int[] a = new int[10];
Random rand = new Random();
int tens, ones, max;

for (int i = 0; i < 10; i++)
{
    a[i] = rand.Next(10, 100);
    tens = a[i] / 10;
    ones = a[i] % 10;
    max = (tens > ones) ? tens : ones;
    
    Console.Write(a[i] + " >> " + max + " ;  ");
}
