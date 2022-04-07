// Программа, которая создает двумерный массив целых случайных чисел
// и находит среднее арифметическое элементов в каждом столбце

using System.Data;

// Задать размерность массива
int m = 5;                     // кол строк
int n = 9;                     // кол столбцов

int[,] array = new int[m,n];     // Создать массив заданных размеров
            
Random rnd = new Random();

FillArray(array);
PrintArray(array);
SummColumns(array);

//------------------------------------------------
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(-10, 11);
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
            Console.Write("{0,8} ",arr[i,j]);
        }
        Console.WriteLine();
    }
}
//------------------------------------------------
void SummColumns(int[,] arr)
{
    
    int numrows   = arr.GetLength(0);
    int numcolums = arr.GetLength(1);
    
    for (int j = 0; j < numcolums; j++)
    {
        Console.Write("    -----");
    }
    Console.WriteLine();
    
    double[] average = new double[numcolums];

    for (int j = 0; j < numcolums; j++)
    {
        for (int i = 0; i < numrows; i++)
        {
            average[j] += arr[i, j];
        }

        average[j] /= numrows;
        Console.Write("{0,8:F} ",average[j]);
    }
}