// Программа, которая выводит все натуральные числа в промежутке от 1 до N

int startNumber = 1;
int finishNumber = 15;

RecursivePrint(startNumber, finishNumber);

//-------------------------------------------
void RecursivePrint(int m, int n)
{
    if (n+1 == m) return;
    Console.Write(m+" ");
    RecursivePrint(m+1,n);
}
//-------------------------------------------