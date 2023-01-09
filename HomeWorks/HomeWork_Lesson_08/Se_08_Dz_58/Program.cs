// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static System.Console;
Clear();
static void MatrixProduction()
{
    int[,] firstMatrix = new int[2, 2] { { 2, 4 }, { 3, 2 } };
    int[,] secondMatrix = new int[2, 2] { { 3, 4 }, { 3, 3 } };
    int[,] matrixProduction = new int[2, 2];
    for (int i = 0; i < 2; i++)
    {
        {
            for (int j = 0; j < 2; j++)
            {
                Write(firstMatrix[i, j] + " ");
            }
            Write("| ");
            for (int k = 0; k < 2; k++)
            {
                Write(secondMatrix[i, k] + " ");
            }
            WriteLine();
        }
    }
    WriteLine();
    for (int i = 0; i < 2; i++)
    {
        Write("|  ");
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                matrixProduction[i, j] = matrixProduction[i, j] + firstMatrix[i, k] * secondMatrix[k, j];
            }
            Write(matrixProduction[i, j] + " ");
        }
        Write(" |");
        WriteLine();
    }
    WriteLine();
}
MatrixProduction();
