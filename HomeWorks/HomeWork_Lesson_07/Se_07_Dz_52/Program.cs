// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
Clear();
int[,] matrix = new int[3, 4];
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{matrix[i, j]} ");
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
            array[i, j] = new Random().Next(1, 99);
        }
    }
}
FileArray(matrix);
PrintArray(matrix);
WriteLine();
WriteLine("Среднее арифметическое каждого столбца :");
double[] arr = new double[matrix.GetLength(1)];
for (int i = 0; i < matrix.GetLength(1); i++)
{
    double result = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        result = result + matrix[j, i];
    }
    arr[i] = result / matrix.GetLength(0);
    string sumresult = string.Format(" {0:f2} ", arr[i]); 
    Write(sumresult);
}
