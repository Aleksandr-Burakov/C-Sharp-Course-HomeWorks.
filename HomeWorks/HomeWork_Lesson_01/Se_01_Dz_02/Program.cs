//Задача 2: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

int a = 4;
int sum = a % 2;
bool result = sum == 0;
if (result)
{
Console.WriteLine("chetnoe");
}
else
{
Console.WriteLine("ne chetnoe");
}

