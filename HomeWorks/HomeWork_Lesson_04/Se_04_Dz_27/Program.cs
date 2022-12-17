// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Строки использовать нельззя


using static System.Console;
Clear();
Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int length = NumberLength(number);
SummaNumbers(number, length);

int NumberLength(int num)
{
    int i = 0;
    while (num > 0)
    {
        num /= 10;
        i++;
    }
    return i;
}
void SummaNumbers(int n, int len)
{
    int summa = 0;
    for (int i = 1; i <= len; i++)
    {
        summa += n % 10;
        n /= 10;
    }
    WriteLine(summa);
}


