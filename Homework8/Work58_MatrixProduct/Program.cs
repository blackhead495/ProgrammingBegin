// Программа, которая находит произведение двух матриц

using System;

int m = 2;                     // Размерность 1 массива
int n = 5;

int p = 5;                     // Размерность 2 массива
int r = 4;

int[,] array1 = new int[m, n];   // Создать массивы заданных размеров
int[,] array2 = new int[p, r];

int[,] prod   = new int[m, r];   // Массив произведения
            
Random rnd = new Random();

if (n != p) 
{
    Console.WriteLine("Матрицы не могут быть перемножены из-за несоответствия размерностей");
}
else
{
    FillArray(array1);
    FillArray(array2);

    Console.WriteLine("---------------------------");
    Console.WriteLine("Первая матрица");
    PrintArray(array1);
    Console.WriteLine("---------------------------");
    Console.WriteLine("Вторая матрица");
    PrintArray(array2);
    Console.WriteLine("---------------------------");
    Console.WriteLine("Результат умножения двух матриц");
    prod = MatrixMult(array1, array2);
    PrintArray(prod);
    Console.WriteLine("---------------------------");
}


//------------------------------------------------
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 10);
        }
    }
}
//------------------------------------------------
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,8}",arr[i,j]);
        }
        Console.WriteLine();
    }
} 
//------------------------------------------------
int[,] MatrixMult(int[,] arr1, int[,] arr2)
{
    int A = arr1.GetLength(0);
    int B = arr1.GetLength(1);
    int C = arr2.GetLength(0);
    int D = arr2.GetLength(1);
    int[,] mux = new int[A, D]; 

    for (int a = 0; a < A; a++)
    {
        for (int d = 0; d < D; d++)
        {
            for (int b = 0; b < B; b++)     // b == c
            {
                mux[a, d] += arr1[a, b] * arr2[b, d];
            }
        }
    }

    return mux;
}
