﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементоm массива.
// [3 7 22 2 78] -> 76


using static System.Console;
Clear();
// WriteLine("Введите количество элементов в массиве :");  -----> Эти строки дают возможность польльзователю самому задать длину массива.      
// int size = Convert.ToInt32(ReadLine());
int size = 7;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int max = numbers[0];
int min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }

    else if (numbers[i] > min)
    {
        min = numbers[i];
    }

}
WriteLine($"{max}");
WriteLine($"{min}");
WriteLine($"Разница между Max и Min элементом массива : {max - min}");

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 101);
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