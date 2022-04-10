// Программа, которая формирует трехмерный массив из неповторяющихся двухзначных чисел и
// построчно выводит элементы и их индексы.

using System;

const int M = 2;                     // Размерность массива
const int N = 3;
const int P = 4;

Random rnd = new Random();

if (M*N*P > 90)
{
    Console.WriteLine("Матрица с таким количеством неповторяющихся чисел\n не может быть создана:");
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
    int I = arr.GetLength(0);
    int J = arr.GetLength(1);
    int K = arr.GetLength(2);
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine($"Количество чисел в массиве ({I} * {J} * {K}) = {I*J*K} ");
    Console.WriteLine("--------------------------------------------------");
    
    for (int i = 0;  i< I; i++)
    {
        for (int j = 0; j < J; j++)
        {
            for (int k = 0; k < K; k++)
            {
                Console.WriteLine($"array[{i}, {j}, {k}] = {arr[i,j,k]}");
            }
        }
        
    }
    
}
//-------------------------------------------------    