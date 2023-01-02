// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// using static System.Console;
// Clear();
// int m = 3;
// int n = 4;
// string[,] table = new string[2, 5];
// table[1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         WriteLine($"-{table[rows, columns]}-");
//     }
// }

using static System.Console;
Clear();

double[,] matrix = new double[3, 4];

void PrintArray(double[,] array)
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

void FileArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-59,59) / 10.0;
        }
    }
}

FileArray(matrix);
WriteLine();
PrintArray(matrix);
