// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();
Write("Введите число M : ");
int m = Convert.ToInt32(ReadLine());
Write("Введите число N : ");
int n = Convert.ToInt32(ReadLine());
SumNumbers(m, n);
void SumNumbers(int m, int n)
{
    Write(Summa(m - 1, n));
}
int Summa(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + Summa(m, n);
        return result;
    }
}