// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



using static System.Console;
Clear();
int[,] RectangularArray = new int[4, 4];
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{RectangularArray[i, j]}  ");
        }
        WriteLine();
    }
}
void FileArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 50);
        }
    }
}
void CalculateSumLineArray(int[,] array)
{
    int row = 0;
    int minsum = 0;
    int sumrow = 0;
    for (int i = 0; i < RectangularArray.GetLength(1); i++)
    {
        row = row + RectangularArray[0, i];
    }
    for (int i = 0; i < RectangularArray.GetLength(0); i++)
    {
        for (int j = 0; j < RectangularArray.GetLength(1); j++)
            sumrow = sumrow + RectangularArray[i, j];
        if (sumrow < row)
        {
            row = sumrow;
            minsum = i;
        }
        WriteLine($"   Сумма элементов строки = {sumrow}");
        sumrow = 0;
    }
    WriteLine();
    WriteLine($"Минимальная сумма элементов = {row} и находится в {minsum + 1} строке.");
}
FileArray(RectangularArray);
PrintArray(RectangularArray);
WriteLine();
CalculateSumLineArray(RectangularArray);
WriteLine();
