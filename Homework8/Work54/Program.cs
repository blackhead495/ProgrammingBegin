// Программа, которая создает двумерный массив случайных чисел
//  и упорядочивает элементы каждой строки по убыванию


int m = 10;                     // Задать размерность массива
int n = 9;

int[,] array = new int[m, n];   // Создать массив заданных размеров
            
Random rnd = new Random();
FillArray(array);
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
            Console.Write("{0,8} ",arr[i,j]);
        }
        Console.WriteLine();
    }
} 
//------------------------------------------------