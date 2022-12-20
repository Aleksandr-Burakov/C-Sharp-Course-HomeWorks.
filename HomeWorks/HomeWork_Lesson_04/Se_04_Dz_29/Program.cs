// Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, записанного в СС по основанию 15
// N: 3 [9, 4, 12] => 2097
// Для проверки можно использовать https://numsys.ru/convert/2097/10/15


using static System.Console;
Clear();
Write("Введите длинну массива: ");
int lenArray = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(0, 14);
    Write(randomArray[i] + ", ");
}


