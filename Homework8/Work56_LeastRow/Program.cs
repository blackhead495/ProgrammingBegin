// Программа, которая создает двумерный массив случайных чисел
//  и находит строку с наименьшей суммой элементов

using System;

const int m = 8;                     // Размерность массива
const int n = 6;

int[,] array = new int[m, n];   // Создать массив заданных размеров
int[]  summ  = new int[m];      // Массив для суммы строк
            
Random rnd = new Random();

FillArray(array);
summ = SummRows(array);
Console.WriteLine("---------------------------");
PrintArray(array, summ);
Console.WriteLine("---------------------------");
Console.WriteLine($"Строка с индексом {RowLeastValue(summ)} имеет наименьшую сумму элементов");


//------------------------------------------------
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(-20, 21);
        }
    }
} 

//------------------------------------------------
int[] SummRows(int[,] arr)
{
    int[] sm = new int[arr.GetLength(0)];
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sm[i] += arr[i, j];
        }
    }

    return sm;
}
//------------------------------------------------
int RowLeastValue(int[] arr)
{
    int numRow = 0;
    int LeastVal = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < LeastVal)
        {
            LeastVal = arr[i];
            numRow = i;
        }
    }

    return numRow;
}

//------------------------------------------------
void PrintArray(int[,] arr, int[] sm)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,8}",arr[i,j]);
        }
        Console.WriteLine($"     ->  {sm[i]}");
    }
}
//------------------------------------------------