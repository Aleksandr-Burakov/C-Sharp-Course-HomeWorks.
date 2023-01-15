// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


using static System.Console;
Clear();
void NatNumber()
{
    WriteLine("Введите натуральное число больше 1:");
    int n = int.Parse(ReadLine());
    int NaturalNumber(int n)
    {
        if (n == 0) return 0;
        else
            Write("{0,3} ", n);
        return NaturalNumber(n - 1);
    }
    Write($"N = {n} -->");
    NaturalNumber(n);
}

NatNumber();