// Создать приложение по обработке двумерного массива строк.
// Если сложно, массив может сделать одномерным
// Приложение позволяет сгенерирвать массив
//  и показать сколько в этом массиве "слов" содержащих восклицательный знак ("!")
// Требование: минимум 4 метода, IndexOf использовать нельзя.

using static System.Console;
Clear();
string[,] word = new string[6, 3]
{ { "one!", "two.", "oops!" },
{ "cat.", "three.", "four." },
{ "a doctor", "five!", "six." },
{ "keeps.", "away!", "a day." },
{ "apple!", "last.", "a man." },
{ "old.", "home", "world." }
};

void PrintArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{word[i, j]}  ");
        }
        WriteLine();
    }
}
void CountArray(string[,] array)
{
    for (int i = 0; i < word.GetLength(1); i++)
    {
        for (int j = 0; j < word.GetLength(0); j++)
        {
            for (int count = 0; (word[j, i] == $"!"); count++)
            {
                if (count > 0)
                {
                    Write("Есть ! знак в массиве слов");
                    Write(count);
                }
                else
                    Write("Нет ! знака в массиве слов");
            }
        }
    }
}


PrintArray(word);
CountArray(word);
