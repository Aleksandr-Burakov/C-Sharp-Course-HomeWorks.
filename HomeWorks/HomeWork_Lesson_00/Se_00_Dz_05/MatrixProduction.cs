//Задайте две матрицы : 

// 2 4 | 3 4
// 3 2 | 3 3

// Найдите произвидение заданных матриц.
// Произвидение матриц равно :

//  Числа первой строки 1матрицы -->  2 4 | умножаем на 1столбец 2матрицы --> 3  результат складываем
//                                                                            3
//  (2 * 3)  плюс + (4 * 3) = 18 получаем число первый элемент произведения в новой 3матрицы.

//  Числа второй строки 1матрицы -->  3 2 | умножаем на 1столбец 2матрицы --> 3  результат складываем
//                                                                            3
//  (3 * 3)  плюс + (2 * 3) = 15 получаем число, второй элемент произведения в новой 3матрицы.


// Числа первой строки 1матрицы -->  2 4 | умножаем на 2столбец 2матрицы --> 4  результат складываем
//                                                                           3
//  (2 * 4)  плюс + (4 * 3) = 20 получаем число третий элемент произведения в новой 3матрицы.

//  Числа второй строки 1матрицы -->  3 2 | умножаем на 2столбец 2матрицы --> 4  результат складываем
//                                                                            3
//  (3 * 4)  плюс + (2 * 3) = 18 получаем число, четвертый элемент произведения в новой 3матрицы.


// Результат полученой матрицы:

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
                Console.Write(firstMatrix[i, j] + " ");             
            }  
            Console.Write("| ");         
            for (int k = 0; k < 2; k++)
            {
                Console.Write(secondMatrix[i, k] + " ");
            }
            WriteLine();
            }
        }   
        WriteLine();
    
    for (int i = 0; i < 2; i++)
    {
        Console.Write("|  ");
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                matrixProduction[i, j] = matrixProduction[i, j] + firstMatrix[i, k] * secondMatrix[k, j];
            }
            Console.Write(matrixProduction[i, j] + " ");
        }
        Console.Write(" |");
        WriteLine();
    }
    WriteLine();
}
MatrixProduction();



//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18




// using static System.Console;
// Clear();

// Random rnd = new Random();
// static int[,] CreateMatrix(int row = 2, int col = 2, int min = 10, int max = 20)
// {
//     int[,] matrix = new int[row , col];
    
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min , max + 1);
//         }
//     }
//     return matrix;
// }
// static void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write(" | ");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1} | ");
//             else Console.Write($"{matrix[i, j],1}");
//         }
//         Console.WriteLine(" | ");
//     }
// }
// static int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
// {
//     var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     if (matrix1.GetLength(1) == matrix2.GetLength(0))
//     {
//         for (int i = 0; i < matrix3.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix3.GetLength(1); j++)
//             {
//                 matrix3[i, j] = 0;
//                 for (int n = 0; n < matrix1.GetLength(1); n++)
//                 {
//                     matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
//                 }
//             }
//         }
//     }
//     return matrix3;
// }

//     int[,] array2D = CreateMatrix(rnd.Next(2, 2), rnd.Next(2, 2), 0, 9);
//     int[,] matrix = CreateMatrix(rnd.Next(2, 2), rnd.Next(2, 2), 0, 9);
//     PrintMatrix(array2D);
//     Console.WriteLine();
//     PrintMatrix(matrix);
//     Console.WriteLine();
//     PrintMatrix(DivMatrix(array2D, matrix));
//     Console.ReadLine();

