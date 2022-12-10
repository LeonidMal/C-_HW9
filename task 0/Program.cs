/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/


int n = GetInt("Введите число: ");
Console.Write(NumbersDown(0, n));

int GetInt (string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int NumbersDown(int a, int b)
{
    if (b <= a)
        return a;
    else
        Console.Write(NumbersDown(a + 1, b) + ", ");
    return a;
}