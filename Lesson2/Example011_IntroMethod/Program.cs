// Вывод наибольшего из 9 чисел
int[] a = { 156, 155, 25, 56, 111, 11, 778, 32, 94 };

int Max(int arg1, int arg2, int arg3)
{
    int max = arg1;
    if (arg2 > max) max = arg2;
    if (arg3 > max) max = arg3;
    return max;
}

// int max1 = Max(a[0], a[1], a[2]);
// int max2 = Max(a[3], a[4], a[5]);
// int max3 = Max(a[6], a[7], a[8]);
//
// int maximum = Max(max1, max2, max3);

int maximum = Max(Max(a[0], a[1], a[2]), Max(a[3], a[4], a[5]), Max(a[6], a[7], a[8]));

Console.WriteLine(maximum);

