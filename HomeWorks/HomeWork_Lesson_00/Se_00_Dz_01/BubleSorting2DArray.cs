//Метод заполнения Двумерного массива рандомными числами + 
//Метод сортировки Двумерного массива пузырьком, 
// от большего элемента массива к меньшему.



using static System.Console;
Clear();
int[,] matrix = new int[3, 4];
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


