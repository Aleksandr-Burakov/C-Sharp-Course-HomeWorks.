// Задача 50. Напишите программу,
//  которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using static System.Console;
Clear();
WriteLine("Двумерный массив : [2, 3]");
WriteLine(" Введите index строки :");
int rows = Convert.ToInt32(Console.ReadLine());
WriteLine(" Введите index столбца :");
int columns = Convert.ToInt32(Console.ReadLine());
WriteLine();
int[,] tablearray = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
if (rows < tablearray.GetLength(0) && columns < tablearray.GetLength(1))
{
    WriteLine($" число {tablearray[rows, columns]} --> является элементом ячейки в двумерном массиве по введенному index. ");
    WriteLine();
    PrintArray(tablearray);
}
else
{
    WriteLine($"  строка с index {rows} и столбец с index {columns} --> нет ячейки c элементом по index введенным пользователем.");
    WriteLine();
    WriteLine($" Введите index строки со значением от 0 до 2 и index столбца со значением от 0 до 3.");
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($" {tablearray[i, j]} ");
        }
        WriteLine();
    }
}
WriteLine();



