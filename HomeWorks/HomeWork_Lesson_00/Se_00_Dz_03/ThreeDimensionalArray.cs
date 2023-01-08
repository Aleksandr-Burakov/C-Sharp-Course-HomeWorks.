//Метод создания Трехмерного массива 2*2*2 с выводом индекса для каждого элемента массива
//Генерируя неповторяемые рандомные значения для элемента массива.


using static System.Console;
Clear();
int[,,] ThreeDimensionalArray = new int[2, 2, 2];

// Генератор неповторяющихся чисел. 
// Метод генерации с сохранением в HashSet,
// проверяя при последуещей генерации был ли элемент получен ранее:

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

// Метод заполнения Трёхмерного массива случайными неповторяющимися числами 
//с использованием локального генератора неповторяющихся чисел.

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

// Метод вывода Трёхмерного массива в Консоль терминала.

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

