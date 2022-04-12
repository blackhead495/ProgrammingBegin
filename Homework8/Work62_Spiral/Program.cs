// Программа, которая заполняет массив по спирали

Console.Write("Введите размерность массива : ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, n]; // Квадратный массив

FillImage(array);
PrintArray(array);

//------------------------------------------------
void FillImage(int[,] matrix)
{
    int row = 0, col = 0;                   // Текущие координаты
    int numTurn = 0;                        // Номер поворота
    int m = matrix.GetLength(1);    // Кол элементов в строке
    int point = m;                          // Кол элементов до поворота
    int dx = 1, dy = 0;                     // Приращения
    
    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[row, col] = i + 1;
        if (--point == 0)          // Окончен? проход вдоль одной линии
        {
            point = m - (numTurn + 2) / 2;
            numTurn++;
            (dx, dy) = (-dy, dx);   // Поочередно сменяются: 0; +1
                                    //                      +1;  0
        }                           //                       0; -1
                                    //                      -1;  0
        col += dx;
        row += dy;
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
//------------------------------------------------