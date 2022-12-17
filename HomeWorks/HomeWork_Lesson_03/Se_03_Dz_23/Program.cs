// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Clear();
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int a = 0;
int i = 1;
while (i <= n)
{
    a = i * i * i;
    Console.Write(a);
    Console.Write(" ");
    //i = i + 1;
    i++;
}


// Console.Clear();
// Console.WriteLine("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine());
// int a = 0;
// for (int i = 1; i <= n; i++)
// {
//     a = i * i * i;
//     Console.Write(a);
//     Console.Write(" ");
// }