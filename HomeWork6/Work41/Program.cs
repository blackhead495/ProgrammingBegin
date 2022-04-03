// Программа, в которой пользователь вводит с клавиатуры M чисел,
// а затем считает сколько из них больше нуля.

var M = 5; // Количество чисел
int[] num = new int[M];

Console.WriteLine($"Введите {M} чисел со знаком: ");
FillArray(num);
Console.WriteLine($"Количество положительных чисел = {CountPositive(num)}");

//------------------------------------------------------
void FillArray(int[] arr)
{
    int L = arr.Length;
    for (int i = 0; i < L; i++)
    {
        Console.Write($"Число номер {i + 1}: ");
        num[i] = Convert.ToInt32(Console.ReadLine());
    }
}
//------------------------------------------------------
int CountPositive(int[] arr)
{
    int Pos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            Pos++;
    }

    return Pos;
}
//------------------------------------------------------
