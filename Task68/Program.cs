﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29
int akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else 
        if ((n == 0) && (m != 0)) return akkerman(m - 1, 1);
        else return akkerman(m - 1, akkerman(m, n - 1));
}

Console.Write("m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
Console.Write($"Значение функции Аккермана равно {akkerman(m, n)} ");