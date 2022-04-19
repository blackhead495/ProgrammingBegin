// Программа, которая наход сумму чисел в массиве, значение которых больше 5

int k = 15, t = 20;  // размеры массива
int[,] array = new int[k, t];
Random rand = new Random();

FillArray(array);
PrintArray(array);
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine($"Сумма элементов больших 5 = {SummElement(array)}");

//----------------------------------------------------
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(1,11);
        }
        
    }
}
//----------------------------------------------------
int SummElement(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j]>5)
            {
                sum += arr[i, j];
            }
        }
    }

    return sum;
}
//----------------------------------------------------
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,4} ", array[i, j]);
        }
        Console.WriteLine();
    }
}
//----------------------------------------------------