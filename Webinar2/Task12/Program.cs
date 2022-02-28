// Создать подпрограммы, которая принимает трехзначное число, а выводит вторую цифру
int InputNumber, SecondDigit;
Random rand = new Random();
InputNumber = rand.Next(100, 1000);

Console.WriteLine(InputNumber+" >> "+Cut(InputNumber));

int Cut(int a)
{
    return a / 10 % 10;
}
