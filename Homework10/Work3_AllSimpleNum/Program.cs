// Программа, принимает натуральное число и
// выводит все простые множители этого числа

Console.Write("Введите натуральное число : ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"{number} -> ");
SimpleNum(number);

//-------------------------------------------
void SimpleNum(int currNum, int del = 1)
{
    if (currNum == 1) return;

    del++;
    if (currNum % del == 0)     
    {
        Console.Write($"{del} ");
        currNum /= del;
        del = 1;
    }
    SimpleNum(currNum, del);
}
//-------------------------------------------
