// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();
WriteLine("Введите длинну массива: ");
int lenArray = Convert.ToInt32(ReadLine());
int[] randomArray = new int[lenArray];
int count = 0;
FillArrayRandomNumbers(randomArray);
PrintArray(randomArray);

for (int i = 0; i < randomArray.Length; i++)
{
    if (randomArray[i] % 2 == 0) 
    count++;
}

WriteLine($"четные числа в массиве -> {count} ");


void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write(array[i] + " ");
    }
    WriteLine();
}