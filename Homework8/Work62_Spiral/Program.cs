// Программа, которая заполняет массив по спирали

Console.Write("Введите размерность массива : ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, n]; // Квадратный массив
int kol = array.Length;       // Количество элементов матрицы
int num = 1;

// for (int i = 0; i < n; i++) // Верхняя сторона массива
// {
//     array[0, i] = num++;
// }
//
// for (int i = 0; i < n; i++) // Правая сторона
// {
//     array[i, n-1] = num++ ;
// }
//
// for (int i = n-1; i >= 0; i--) // Левая сторона
// {
//     array[n-1, i] = num++ ;
// }

FillImage(0,0);
PrintArray(array);

void FillImage(int row, int col)
{
    if (array[row,col] == 0 )
    {
        array[row, col] = num++;
        if (col<2)
        {
            FillImage(row,col+1);   // Вправо
        }
        else if(row<2)
        {
            FillImage(row+1,col);   // Вниз
        }
        else if(col > 0)
        {
            FillImage(row,col-1);   // Влево
        }
        else if (row > 0)
        {
            FillImage(row-1,col);   // Вверх
        }
        else
        {
            return;
        }
    }
    else
    {
        return;
    }
}


//------------------------------------------------
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,8}",matrix[i,j]);
        }
        Console.WriteLine();
    }
} 

