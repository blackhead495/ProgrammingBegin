// Программа, которая формирует трехмерный массив из неповторяющихся двухзначных чисел и
// построчно выводит элементы и их индексы.

using System;

int M = 5;                     // Размерность массива
int N = 6;
int P = 2;

Random rnd = new Random();

if (M*N*P >90)
{
    Console.WriteLine("Матрица такого количества неповторяющихся чисел\n не может быть создана:");
    Console.WriteLine($"({M} * {N} * {P}) = {M*N*P} > 90");
}
else
{
    int[,,] array = new int[M, N, P];

    FillArray(array);
    PrintArray(array);
}

//-------------------------------------------------
void FillArray(int[,,] arr)
{
    int I = arr.GetLength(0);
    int J = arr.GetLength(1);
    int K = arr.GetLength(2);
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine($"Количество чисел в массиве ({I} * {J} * {K}) = {I*J*K} ");
    Console.WriteLine("--------------------------------------------------");
    
    int[] num = new int[100]; // Проверочный массив.

    for (int i = 0; i < I; i++)
    {
        for (int j = 0; j < J; j++)
        {
            for (int k = 0; k < K; k++)
            {
                do
                {
                    arr[i, j, k] = rnd.Next(10, 100);
                } while (num[arr[i, j, k]] > 0);

                num[arr[i, j, k]]++;
            }
        }
    }
}   

//-------------------------------------------------
void PrintArray(int[,,] arr)
{
    for (int i = 0;  i< arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.WriteLine($"array[{i}, {j}, {k}] = {arr[i,j,k]}");
            }
        }
        
    }
    
}
//-------------------------------------------------    