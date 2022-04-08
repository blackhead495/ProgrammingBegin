// Программа, которая создает двумерный массив случайных чисел
//  и упорядочивает элементы каждой строки по убыванию


using System;

int m = 3;                     // Задать размерность массива
int n = 7;

int[,] array = new int[m, n];   // Создать массив заданных размеров
            
Random rnd = new Random();
FillArray(array);
PrintArray(array);
Console.WriteLine("---------------------------");
SortTwoDimArray(array);
PrintArray(array);

//------------------------------------------------
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(-100, 101);
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
void SortTwoDimArray(int[,] arr)
{
    int H = arr.GetLength(0);       // кол строк
    int L = arr.GetLength(1) - 1;   // кол столбцов - 1
    
    for (int i = 0; i < H; i++) 
    {
        for (int j = 0; j < L; j++)
        {
            for (int k = 0; k < L; k++)
            {
                if (arr[i,k] < arr[i,k+1])
                {
                    (arr[i, k], arr[i, (k + 1)]) = (arr[i, (k + 1)], arr[i, k]);
                }
            }
        }
    }
}