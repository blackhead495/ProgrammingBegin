// Программа, которая создает двухмерный массив размером m x n
//  и заполняет его случайными вещественными числами

int m = 10;                         // Задать размерность массива
int n = 9;

double[,] array = new double[m, n];     // Создать массив заданных размеров
            
Random rnd = new Random();
FillArray(array);
PrintArray(array);

//------------------------------------------------
void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = (rnd.NextDouble()); // Получить вещественное число от 0 до 1
            arr[i,j] *= rnd.Next(-100, 101); // Расширить диапазон чисел от -100 до 100
        }
    }
} 

//------------------------------------------------
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            //Console.Write($"{arr[i, j]:F}\t");
            Console.Write("{0,8:F} ",arr[i,j]);
        }
        Console.WriteLine();
    }
} 
//------------------------------------------------
