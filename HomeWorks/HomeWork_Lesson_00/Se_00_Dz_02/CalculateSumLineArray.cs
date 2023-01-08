// Метод создание,заполнение Двумерного Прямоугольного массива рандомными числами,
// Подсчет суммы строки и вывод минимальной суммы элементов строки с номером строки.
 
// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки в которой наименьшая сумма элементов:

// Минимальная сумма элементов = 34 и находится в 1 строке. 



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
