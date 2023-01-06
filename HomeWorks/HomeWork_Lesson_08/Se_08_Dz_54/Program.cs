// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


using static System.Console;
Clear();
int[,] matrix = new int [3, 4];
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

void BubbleSorting(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int a = j + 1; a < array.GetLength(1); a++)
            {
                if (array[i, j] < array[i, a])
                {
                    int temp = array[i, a];
                    array[i, a] = array[i, j];
                    array[i, j] = temp;
                }
            }   
        }  
    }
}
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



FileArray(matrix);
PrintArray(matrix);
WriteLine();
BubbleSorting(matrix);
PrintArray(matrix);


