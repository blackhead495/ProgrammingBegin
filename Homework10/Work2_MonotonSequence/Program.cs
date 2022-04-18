// Дана монотонная последовательность, в которой каждое натуральное число n встречается ровно n раз:
// 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5
// Дано число m. Вывести первые m членов этой последовательности

Console.Write("Введите целое положительное число : ");
int number = Convert.ToInt32(Console.ReadLine());

MonoSeq(number);
//Console.WriteLine();

//-----------------------------------------------------------
void MonoSeq(int countAll, int currNum = 1, int countNum = 0)
{
    if (countAll == 0)   return;

    countAll--;
    countNum++;
                
    if (countNum > currNum)
    {
        currNum++;
        countNum = 1;
    }

    Console.Write($"{currNum} ");
    MonoSeq(countAll, currNum, countNum);
}
//-----------------------------------------------------------
