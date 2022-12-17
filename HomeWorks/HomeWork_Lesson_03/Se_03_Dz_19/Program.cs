// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да



Console.Clear();
Console.WriteLine("Введите число:");
int q = Convert.ToInt32(Console.ReadLine());
int a = q;
int c = 0;
while (a > 0)
{
    int o = a % 10;
    c = c * 10 + o;
    a = a / 10;

}
if (q == c)
{
    Console.WriteLine(" Да, палиндром ");
}
else
{
    Console.WriteLine(" Нет, не палиндром ");
}