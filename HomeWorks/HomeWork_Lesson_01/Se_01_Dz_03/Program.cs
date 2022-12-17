//Задача 3: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8


//Console.Clear();
//Console.WriteLine("Введите число:");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Чётные числа от 1 до " + n);
//int i = 1;
//while (i <= n)
//{
//if (i % 2 != 1)
//{
//Console.Write(i + ", ");
//}
//i = i + 1;
//}


// Решение которое нравится мне.


Console.Clear();
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чётные числа от 1 до " + n);
int i = 1;
bool no = true;
while (i <= n)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        no = false;
    }
    i = i + 1;
}
if (no)
{
    Console.WriteLine("Нет чётных чисел!");
}


// Решение от Наставника. Спасибо за подсказку! 

//Console.Clear();
//Console.WriteLine ("Напишите число:");
//int n = Convert.ToInt32(Console.ReadLine());
//int i = 2;
//while (i <= n)
//{
//Console.Write($"{i}, ");
//i += 2;
//}