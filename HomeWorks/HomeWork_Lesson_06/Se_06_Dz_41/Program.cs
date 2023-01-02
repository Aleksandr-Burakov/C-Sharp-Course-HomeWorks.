// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();
WriteLine("Введите числа через запятую : ");
string? input = ReadLine();
int[] m = ParseStringToArray(input);
int Comparison(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < m.Length; i++)
    {
        if (numbers[i] > 0) count += 1;
    }
    return count;
}
Write($"Введено чисел больше нуля : {Comparison(m)} ");
int[] ParseStringToArray(string input)
{
    int CountNum = CountNumbers(input);
    int[] m = new int[CountNum];
    int indexNumber = 0;
    string result = String.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ',')
        {
            result += input[i];
        }
        else
        {
            m[indexNumber] = Convert.ToInt32(result);
            indexNumber++;
            result = String.Empty;
        }
    }
    if (input[input.Length - 1] != ',')
        m[indexNumber] = Convert.ToInt32(result);
    return m;
}
int CountNumbers(string input)
{
    int count;
    if (input[input.Length - 1] == ',')
        count = 0;
    else
        count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
            count++;
    }
    return count;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        WriteLine(array[i] + " ");
    }
    WriteLine();
}