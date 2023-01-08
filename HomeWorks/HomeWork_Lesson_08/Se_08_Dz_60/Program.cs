// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


using static System.Console;
Clear();
int[,,] ThreeDimensionalArray = new int[2, 2, 2];
HashSet<int> numbers = new HashSet<int>();
Random randomNum = new Random();
int GenerateUniqueNumber()
{
    while (true)
    {
        var num = randomNum.Next(10, 19);
        if (!numbers.Contains(num))
        {
            numbers.Add(num);
            return num;
        }
    }
}
void FileArray(int[,,] array)
{
    for (int i = 0; i < ThreeDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < ThreeDimensionalArray.GetLength(1); j++)
        {
            for (int k = 0; k < ThreeDimensionalArray.GetLength(2); k++)
            {
                ThreeDimensionalArray[i, j, k] = GenerateUniqueNumber();
            }
        }
    }
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < ThreeDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < ThreeDimensionalArray.GetLength(1); j++)
        {
            for (int k = 0; k < ThreeDimensionalArray.GetLength(2); k++)
            {
                Write($"{ThreeDimensionalArray[i, j, k]} ({j}, {k}, {i}) ");
            }
            WriteLine();
        }
        WriteLine();
    }
}
FileArray(ThreeDimensionalArray);
PrintArray(ThreeDimensionalArray);
