// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (0,0); B (1,1), -> ~1.4
// A (2,4); B (0,7) -> ~3.6

using static System.Console;
Clear();
Write("Введите x первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Write("Введите x второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Write("Введите у первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Write("Введите у второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
int a = x2 - x1;
int b = y2 - y1;
double length = Math.Sqrt(a * a + b * b);
WriteLine($"Расстояние между двух точек {length}");
