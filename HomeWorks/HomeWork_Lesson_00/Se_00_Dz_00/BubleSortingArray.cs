//Метод заполнения одномерного массива рандомными числами + 
//Метод сортировки одномерного массива пузырьком, 
// от большего элемента массива к меньшему.



using static System.Console;
Clear();
int[] matrix = new int[9];
void FileArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        matrix[i] = new Random().Next(1, 99);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Write($"{matrix[i]} ");
    }
    WriteLine();
}
void BubbleSorting(int[] array)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = i + 1; j < matrix.Length; j++)
        {
            if (matrix[i] < matrix[j])
            {
                int temp = matrix[i];
                matrix[i] = matrix[j];
                matrix[j] = temp;
            }
        }
        Write($"{matrix[i]} ");
    }
}
FileArray(matrix);
PrintArray(matrix);
WriteLine();
BubbleSorting(matrix);