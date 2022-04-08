// Программа, которая принимает на вход позиции элемента в массиве
// и возвращает значение этого элемента
// или же указание того, что такого элемента нет.

using System.Data;

int m = 10;                         // Задать размерность массива
int n = 9;

int[,] array = new int[m,n];     // Создать массив заданных размеров
            
Random rnd = new Random();

FillArray(array);
PrintArray(array);
PositionRequest(array);

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
            Console.Write("{0,8} ",arr[i,j]);
        }
        Console.WriteLine();
    }
}

//------------------------------------------------
void PositionRequest(int[,] arr)
{
    Console.Write("Введите номер строки: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int column = Convert.ToInt32(Console.ReadLine());
    if ((row    < 0) || (row    >= arr.GetLength(0))   ||
        (column < 0) || (column >= arr.GetLength(1)))
    {
        Console.WriteLine("Такого элемента матрицы не существует!");
    }
    else
    {
        Console.WriteLine(" -> {0}", arr[row, column]);
    }
}