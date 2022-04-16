// Программа, которая принимает два массива info и data. 
// В массиве info хранятся двоичные представления нескольких чисел (без разделителя)
// В массиве data хранится информация о количестве бит, которые занимают числа из массива info.
// Программа составляет массив десятичных представлений чесел массива data с учетом информации из массива info.

Random rand = new Random();
int[] info = new int[rand.Next(2, 5)];

int dataLength = 0;
Console.WriteLine("Массив info");
for (int i = 0; i < info.Length; i++)
{
    info[i] = rand.Next(1, 4);
    Console.Write(info[i] + "\t");
    dataLength += info[i];
}

Console.WriteLine();
int[] data = new int[dataLength];
Console.WriteLine("Массив data");
for (int i = 0; i < data.Length; i++)
{
    data[i] = rand.Next(0, 2);
    Console.Write(data[i] +"\t");
}
Console.WriteLine();
int[] result = new int[info.Length];
int lastIndex = 0;
for (int i = 0; i < info.Length; i++)
{
    int number = 0;
    double num10 = 0;
    int pow = info[i] - 1;
    for (int j = lastIndex; j < lastIndex+ info[i]; j++)
    {
        number = number * 10 + data[j];
        num10 += data[j] * Math.Pow(2, pow);
        pow--;
    }
    lastIndex += info[i];
    result[i] = (int)num10;
    //Console.WriteLine(number);
}

Console.WriteLine("Итоговый массив: ");
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i]+"\t");
}