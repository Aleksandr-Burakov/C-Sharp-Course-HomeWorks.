// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ Math.Pow


using static System.Console;
Clear();
Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
ToDegree(numA, numB);
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    WriteLine(result);
}

