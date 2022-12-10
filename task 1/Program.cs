/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M
 до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int m = GetInt("Введите первое число: ");
int n = GetInt("Введите последнее число: ");
Console.Write(SumNum(n, m));


int GetInt (string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNum (int a, int b)
{
    if (a == b)
        return b;
    else
        return a + SumNum(a - 1, b);
}
